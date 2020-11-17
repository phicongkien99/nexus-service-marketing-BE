using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Nexus.Common.Enum;
using System.Web.Http.Cors;
using Nexus.DatabaseDAL.Common;
using Nexus.Entity;
using Nexus.Entity.Entities;
using Nexus.Memory;
using Nexus.Models;
using Nexus.Models.Request;
using Nexus.Models.Response;
using Nexus.Utils;
namespace Nexus.Controllers
{
	public class ContractController: ApiController
	{
		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public async Task<IHttpActionResult> Get()
		{
			try
			{
				var lstData = MemoryInfo.GetAllContract();
                List<ContractRes> lstResult = new List<ContractRes>();
				if (lstData != null)
					lstData = lstData.Where(x => x.IsDeleted != null && x.IsDeleted != 1).ToList();
                foreach (var item in lstData)
                {
                    var customer = MemoryInfo.GetCustomer(item.IdCustomer);
                    ContractRes temp = new ContractRes(item, customer);
                    lstResult.Add(temp);

                }
				var res = new RequestErrorCode(true, null, null);
				res.ListDataResult.AddRange(lstResult);
				return Ok(res);
			}
			catch (Exception ex)
			{
				Logger.Write(ex.ToString());
			}
			return BadRequest("Unknow");
		}

		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public async Task<IHttpActionResult> Get(int id)
		{
			try
			{
				var data = MemoryInfo.GetContract(id);
				if (data != null && data.IsDeleted == 1)
					data = null;
				var res = new RequestErrorCode(true, null, null);
                if (data != null && data.IsDeleted == 1)
                {
                    res.DataResult = null;
                    return Ok(res);
                }

                if (data != null)
                {
                    var lstPayment =
                        MemoryInfo.GetListPaymentByField(data.ContractId, Payment.PaymentFields.IdContract);
                    var customer = MemoryInfo.GetCustomer(data.IdCustomer);
                    ContractRes result = new ContractRes(data, customer, lstPayment);
                    res.DataResult = result;
                    return Ok(res);
                }
                res.DataResult = data;
                return Ok(res);
			}
			catch (Exception ex)
			{
				Logger.Write(ex.ToString());
			}
			return BadRequest("Unknow");
		}

		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public async Task<IHttpActionResult> Post([FromBody] ContractReq req)
		{
			try
			{
				string errorMessage = "UnknowError";
				string errorCode = ErrorCodeEnum.UnknownError.ToString();
				#region token
				var header = Request.Headers;
				if (header.Authorization == null)
				{
					return StatusCode(HttpStatusCode.Unauthorized);
				}
				var token = header.Authorization.Parameter;
				Employee employee;
				if (string.IsNullOrWhiteSpace(token) || !TokenManager.ValidateToken(token, out employee))
				{
					return StatusCode(HttpStatusCode.Unauthorized);
				}
				#endregion
				if (!Operator.IsAdmin(employee))
					return Ok(new RequestErrorCode(false, ErrorCodeEnum.Error_NotHavePermision.ToString(), "Khong co quyen"));

				#region Validate
				if (!Validate(req.GetEntity(), out errorCode, out errorMessage))
				{
					return Ok(new RequestErrorCode(false, errorCode, errorMessage));
				}
				#endregion
                // lay connectionTypeName
                var startStringId = req.ServiceFormId[0];
                var lstContractWithStartId = MemoryInfo.GetListContractByStartId(startStringId.ToString());
                int idContractWithStartId = lstContractWithStartId.Count + 1;
                string contractId = startStringId.ToString();
                int countZeroNumber = 15 - idContractWithStartId.ToString().Length;
                for (int i = 0; i < countZeroNumber; i++)
                {
                    contractId += "0";

                }
                contractId += idContractWithStartId.ToString();
                req.ContractId = contractId;
				#region Tạo key
				var oldKey = Memory.Memory.GetMaxKey(req.GetEntity().GetName());
				int newKey = oldKey + 1;
				// set key
				req.Id = newKey;
				#endregion

				#region Process
				req.CreatedAt = DateTime.Now;
				req.CreatedBy = employee.Id;
				req.IsDeleted = 0;
				UpdateEntitySql updateEntitySql = new UpdateEntitySql();
				var lstCommand = new List<EntityCommand>();
				lstCommand.Add(new EntityCommand { BaseEntity = new Entity.Entity(req.GetEntity()), EntityAction = EntityAction.Insert });
				bool isOkDone = updateEntitySql.UpdateDefault(lstCommand);
				if (!isOkDone)
				{
					return Ok(new RequestErrorCode(false, errorCode, errorMessage));
				}
				#endregion
				// update memory
				MemorySet.UpdateAndInsertEntity(req.GetEntity());
				var result = new RequestErrorCode(true);
				result.DataResult = req;
				return Ok(result);
			}
			catch (Exception ex)
			{
				Logger.Write(ex.ToString());
			}
			return BadRequest("Unknow");
		}

		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public async Task<IHttpActionResult> Put(int id,[FromBody]Contract req)
		{
			try
			{
				string errorMessage = "UnknowError";
				string errorCode = ErrorCodeEnum.UnknownError.ToString();
				#region token
				var header = Request.Headers;
				if (header.Authorization == null)
				{
					return StatusCode(HttpStatusCode.Unauthorized);
				}
				var token = header.Authorization.Parameter;
				Employee employee;
				if (string.IsNullOrWhiteSpace(token) || !TokenManager.ValidateToken(token, out employee))
				{
					return StatusCode(HttpStatusCode.Unauthorized);
				}
				#endregion
				if (!Operator.IsAdmin(employee))
					return Ok(new RequestErrorCode(false, ErrorCodeEnum.Error_NotHavePermision.ToString(), "Khong co quyen"));

				#region Validate
				if (!ValidateUpdate(req, out errorCode, out errorMessage))
				{
					return Ok(new RequestErrorCode(false, errorCode, errorMessage));
				}
				#endregion

				#region Check exist
				var obj = MemoryInfo.GetContract(id);
				if (obj == null)
				{
					return Ok(new RequestErrorCode(false, ErrorCodeEnum.DataNotExist.ToString(), "Khong ton tai"));
				}
				#endregion
				req.Id = obj.Id; // gan lai id de update
				#region Process
				req.UpdatedAt = DateTime.Now;
				req.UpdatedBy = employee.Id;
				UpdateEntitySql updateEntitySql = new UpdateEntitySql();
				var lstCommand = new List<EntityCommand>();
				lstCommand.Add(new EntityCommand { BaseEntity = new Entity.Entity(req), EntityAction = EntityAction.Update });
				bool isOkDone = updateEntitySql.UpdateDefault(lstCommand);
				if (!isOkDone)
				{
					return Ok(new RequestErrorCode(false, errorCode, errorMessage));
				}
				#endregion
				// update memory
				MemorySet.UpdateAndInsertEntity(req);
				var result = new RequestErrorCode(true);
				result.DataResult = req;
				return Ok(result);
			}
			catch (Exception ex)
			{
				Logger.Write(ex.ToString());
			}
			return BadRequest("Unknow");
		}

		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public async Task<IHttpActionResult> Delete(int id)
		{
			try
			{
				string errorMessage = "UnknowError";
				string errorCode = ErrorCodeEnum.UnknownError.ToString();
				#region token
				var header = Request.Headers;
				if (header.Authorization == null)
				{
					return StatusCode(HttpStatusCode.Unauthorized);
				}
				var token = header.Authorization.Parameter;
				Employee employee;
				if (string.IsNullOrWhiteSpace(token) || !TokenManager.ValidateToken(token, out employee))
				{
					return StatusCode(HttpStatusCode.Unauthorized);
				}
				#endregion
				if (!Operator.IsAdmin(employee))
					return Ok(new RequestErrorCode(false, ErrorCodeEnum.Error_NotHavePermision.ToString(), "Khong co quyen"));

				#region Check exist
				var obj = MemoryInfo.GetContract(id);
				if (obj == null)
				{
					return Ok(new RequestErrorCode(false, ErrorCodeEnum.DataNotExist.ToString(), "Khong ton tai"));
				}
				#endregion

				bool isHasDeleteProperties = obj.GetType().GetProperty("IsDeleted") != null;
				if (!isHasDeleteProperties)
				{
					return Ok(new RequestErrorCode(false, ErrorCodeEnum.DataNotExist.ToString(), "Khong ton tai"));
				}
				obj.IsDeleted = 1;

				#region Process
				UpdateEntitySql updateEntitySql = new UpdateEntitySql();
				var lstCommand = new List<EntityCommand>();
				lstCommand.Add(new EntityCommand { BaseEntity = new Entity.Entity(obj), EntityAction = EntityAction.Update });
				bool isOkDone = updateEntitySql.UpdateDefault(lstCommand);
				if (!isOkDone)
				{
					return Ok(new RequestErrorCode(false, errorCode, errorMessage));
				}
				#endregion
				// update memory
				MemorySet.UpdateAndInsertEntity(obj);
				var result = new RequestErrorCode(true);
				result.DataResult = obj;
				return Ok(result);
			}
			catch (Exception ex)
			{
				Logger.Write(ex.ToString());
			}
			return BadRequest("Unknow");
		}

		#region Validation
		public static bool Validate(Contract obj, out string errorCode, out string errorMess)
		{
			errorCode = null;
			errorMess = null;
			try
			{
				if (obj == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					return false;
				}
				if (obj.Address == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Address not allow null value";
					return false;
				}
				if (obj.ContractId == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "ContractId not allow null value";
					return false;
				}
				if (obj.CreatedAt == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "CreatedAt not allow null value";
					return false;
				}
				if (obj.IdArea == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdArea not allow null value";
					return false;
				}
				if (obj.IdCustomer == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdCustomer not allow null value";
					return false;
				}
			}
			catch (Exception ex)
			{
				Logger.Write(ex.ToString());
				throw;
			}
			return true;
		}

		public static bool ValidateUpdate(Contract obj, out string errorCode, out string errorMess)
		{
			errorCode = null;
			errorMess = null;
			try
			{
				if (obj == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					return false;
				}
				if (obj.Address == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Address not allow null value";
					return false;
				}
				if (obj.ContractId == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "ContractId not allow null value";
					return false;
				}
				if (obj.CreatedAt == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "CreatedAt not allow null value";
					return false;
				}
				if (obj.IdArea == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdArea not allow null value";
					return false;
				}
				if (obj.IdCustomer == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdCustomer not allow null value";
					return false;
				}
			}
			catch (Exception ex)
			{
				Logger.Write(ex.ToString());
				throw;
			}
			return true;
		}
		#endregion



	}
}

