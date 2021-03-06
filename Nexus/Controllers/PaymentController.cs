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
	public class PaymentController: ApiController
	{
		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public async Task<IHttpActionResult> Get()
		{
			try
			{
				var lstData = MemoryInfo.GetAllPayment();
				if (lstData != null)
					lstData = lstData.Where(x => x.IsDeleted != null && x.IsDeleted != 1).ToList();
                List<PaymentRes> lstResult = new List<PaymentRes>();
				foreach (var payment in lstData)
                {
                    if (payment.IsDeleted != 1)
                    {
                        var lstPaymentFees = MemoryInfo.GetListPaymentFeeByField(payment.Id.ToString(),
                            PaymentFee.PaymentFeeFields.IdPayment);
                        PaymentRes itemRes = new PaymentRes(payment, lstPaymentFees);
                        lstResult.Add(itemRes);
					}
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
				var data = MemoryInfo.GetPayment(id);
                var res = new RequestErrorCode(true, null, null);
				if (data != null && data.IsDeleted == 1 || data == null)
                {
                    res.DataResult = null;
                    return Ok(res);
				}
                var lstPaymentFees = MemoryInfo.GetListPaymentFeeByField(data.Id.ToString(),
                    PaymentFee.PaymentFeeFields.IdPayment);
                PaymentRes itemRes = new PaymentRes(data, lstPaymentFees);
				res.DataResult = itemRes;
				return Ok(res);
			}
			catch (Exception ex)
			{
				Logger.Write(ex.ToString());
			}
			return BadRequest("Unknow");
		}

		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public async Task<IHttpActionResult> Post([FromBody]PaymentReq req)
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
                var entityData = req.GetEntity();
				#region Validate
				if (!Validate(entityData, out errorCode, out errorMessage))
				{
					return Ok(new RequestErrorCode(false, errorCode, errorMessage));
				}
				#endregion

				#region Tạo key
				var oldKey = Memory.Memory.GetMaxKey(entityData.GetName());
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
                if (req.ListDataTemp != null)
                {
                    foreach (var paymentFee in req.ListDataTemp)
                    {
                        paymentFee.IdPayment = newKey;
                        paymentFee.IsDeleted = 0;
						lstCommand.Add(new EntityCommand { BaseEntity = new Entity.Entity(paymentFee), EntityAction = EntityAction.Insert });
                        MemorySet.UpdateAndInsertEntity(paymentFee);
					}
                }
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
		public async Task<IHttpActionResult> Put(int id,[FromBody] PaymentReq req)
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

                var entityData = req.GetEntity();
				#region Validate
				if (!ValidateUpdate(entityData, out errorCode, out errorMessage))
				{
					return Ok(new RequestErrorCode(false, errorCode, errorMessage));
				}
				#endregion

				#region Check exist
				var obj = MemoryInfo.GetPayment(id);
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
				lstCommand.Add(new EntityCommand { BaseEntity = new Entity.Entity(req.GetEntity()), EntityAction = EntityAction.Update });
                var isOkDone = updateEntitySql.UpdateDefault(lstCommand);
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
				var obj = MemoryInfo.GetPayment(id);
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
                var lstPaymentFee = MemoryInfo.GetListPaymentFeeByField(obj.Id.ToString(), PaymentFee.PaymentFeeFields.IdPayment);
                foreach (var paymentFee in lstPaymentFee)
                {
					lstCommand.Add(new EntityCommand { BaseEntity = new Entity.Entity(paymentFee), EntityAction = EntityAction.Delete });
                    MemorySet.RemoveMemory(paymentFee);
				}
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
        public static bool Validate(Payment obj, out string errorCode, out string errorMess)
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
                if (obj.IdContract == null)
                {
                    errorCode = ErrorCodeEnum.DataInputWrong.ToString();
                    errorMess = "IdContract not allow null value";
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

        public static bool ValidateUpdate(Payment obj, out string errorCode, out string errorMess)
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
                if (obj.IdContract == null)
                {
                    errorCode = ErrorCodeEnum.DataInputWrong.ToString();
                    errorMess = "IdContract not allow null value";
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

