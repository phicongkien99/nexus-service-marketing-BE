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
using Nexus.Utils;
namespace Nexus.Controllers
{
	public class ServiceFormController: ApiController
	{
		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public async Task<IHttpActionResult> Get()
		{
			try
			{
				var lstData = MemoryInfo.GetAllServiceForm();
				if (lstData != null)
					lstData = lstData.Where(x => x.IsDeleted != null && x.IsDeleted != 1).ToList();
				var res = new RequestErrorCode(true, null, null);
				res.ListDataResult.AddRange(lstData);
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
				var data = MemoryInfo.GetServiceForm(id);
				if (data != null && data.IsDeleted == 1)
					data = null;
				var res = new RequestErrorCode(true, null, null);
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
		public async Task<IHttpActionResult> Get(string serviceFormId)
		{
			try
			{
				var lstSearch = MemoryInfo.GetListServiceFormByField(serviceFormId,ServiceForm.ServiceFormFields.ServiceFormId);
                var data = lstSearch[0];
				if (data != null && data.IsDeleted == 1)
					data = null;
				var res = new RequestErrorCode(true, null, null);
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
		public async Task<IHttpActionResult> Post([FromBody]ServiceForm req)
		{
			try
			{
				string errorMessage = "UnknowError";
				string errorCode = ErrorCodeEnum.UnknownError.ToString();
				
				#region Validate
				if (!Validate(req, out errorCode, out errorMessage))
				{
					return Ok(new RequestErrorCode(false, errorCode, errorMessage));
				}
				#endregion
				// lay connectionTypeName
                string cnTypeName = "S";
                var svPack =
                    MemoryInfo.GetListServicePackByField(req.IdServicePack.ToString(),
                        ServicePack.ServicePackFields.Id);
                if (svPack != null && svPack.Count > 0 && svPack[0] != null)
                {
                    var cnType = MemoryInfo.GetListConnectionTypeByField(svPack[0].IdConnectionType.ToString(),
                        ConnectionType.ConnectionTypeFields.Id);
                    if (cnType != null && cnType.Count > 0 && cnType[0] != null)
                    {
                        cnTypeName = cnType[0].Name;
                    }

				}

                var startStringId = cnTypeName[0];
                var lstSvFormWithStartId = MemoryInfo.GetListServicesFormByStartId(startStringId.ToString());
                int idSvFormWithStartId = lstSvFormWithStartId.Count + 1;
                string serviceFormId = startStringId.ToString();
                int countZeroNumber = 10 - idSvFormWithStartId.ToString().Length;
                for (int i = 0; i < countZeroNumber; i++)
                {
                    serviceFormId += "0";

                }
                serviceFormId += idSvFormWithStartId.ToString();
                req.ServiceFormId = serviceFormId;
				#region Tạo key
				var oldKey = Memory.Memory.GetMaxKey(req.GetName());
				int newKey = oldKey + 1;
				// set key
				req.Id = newKey;
				#endregion

				#region Process
				req.CreatedAt = DateTime.Now;
				req.CreatedBy = 0;
				req.IsDeleted = 0;
				UpdateEntitySql updateEntitySql = new UpdateEntitySql();
				var lstCommand = new List<EntityCommand>();
				lstCommand.Add(new EntityCommand { BaseEntity = new Entity.Entity(req), EntityAction = EntityAction.Insert });
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
		public async Task<IHttpActionResult> Put(int id,[FromBody]ServiceForm req)
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
				var obj = MemoryInfo.GetServiceForm(id);
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
				var obj = MemoryInfo.GetServiceForm(id);
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
        public static bool Validate(ServiceForm obj, out string errorCode, out string errorMess)
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
                if (obj.IdArea == null)
                {
                    errorCode = ErrorCodeEnum.DataInputWrong.ToString();
                    errorMess = "IdArea not allow null value";
                    return false;
                }
                if (obj.IdServicePack == null)
                {
                    errorCode = ErrorCodeEnum.DataInputWrong.ToString();
                    errorMess = "IdServicePack not allow null value";
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

        public static bool ValidateUpdate(ServiceForm obj, out string errorCode, out string errorMess)
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
                if (obj.IdArea == null)
                {
                    errorCode = ErrorCodeEnum.DataInputWrong.ToString();
                    errorMess = "IdArea not allow null value";
                    return false;
                }
                if (obj.IdServicePack == null)
                {
                    errorCode = ErrorCodeEnum.DataInputWrong.ToString();
                    errorMess = "IdServicePack not allow null value";
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

