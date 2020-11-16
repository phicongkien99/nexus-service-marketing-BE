using System;
using System.Net;
using System.Collections.Generic;
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
	public class ServicePackController: ApiController
	{
		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public async Task<IHttpActionResult> Get()
		{
			try
			{
				List<ServicesPackRes> lstResult = new List<ServicesPackRes>();
				var lstData = MemoryInfo.GetAllServicePack();
                foreach (var servicePack in lstData)
                {
                    if (servicePack.IsDeleted != 1)
                    {
                        string cnTypeName = "";
                        var connectType = MemoryInfo.GetConnectionType(servicePack.IdConnectionType);
                        if (connectType != null)
                        {
                            cnTypeName = connectType.Name;
                        }

                        var lstSvPackFee = MemoryInfo.GetListServicePackFeeByField(servicePack.Id.ToString(),
                            ServicePackFee.ServicePackFeeFields.IdServicePack);
                        ServicesPackRes itemRes = new ServicesPackRes(servicePack, cnTypeName, lstSvPackFee);
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
				var data = MemoryInfo.GetServicePack(id);
                ServicesPackRes itemRes = null;
                if (data != null)
                {
                    if (data.IsDeleted != 1)
                    {
                        string cnTypeName = "";
                        var connectType = MemoryInfo.GetConnectionType(data.IdConnectionType);
                        if (connectType != null)
                        {
                            cnTypeName = connectType.Name;
                        }
                        var lstSvPackFee = MemoryInfo.GetListServicePackFeeByField(data.Id.ToString(),
                            ServicePackFee.ServicePackFeeFields.IdServicePack);
						itemRes = new ServicesPackRes(data, cnTypeName, lstSvPackFee);
					}
				}
				var res = new RequestErrorCode(true, null, null);
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
		public async Task<IHttpActionResult> Post([FromBody]ServicePackReq req)
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
                    foreach (var servicePackFee in req.ListDataTemp)
                    {
                        lstCommand.Add(new EntityCommand { BaseEntity = new Entity.Entity(servicePackFee), EntityAction = EntityAction.Insert });
                    }
                }
				lstCommand.Add(new EntityCommand { BaseEntity = new Entity.Entity(entityData), EntityAction = EntityAction.Insert });
				bool isOkDone = updateEntitySql.UpdateDefault(lstCommand);
				if (!isOkDone)
				{
					return Ok(new RequestErrorCode(false, errorCode, errorMessage));
				}
				#endregion
				// update memory
				MemorySet.UpdateAndInsertEntity(entityData);
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
		public async Task<IHttpActionResult> Put(int id,[FromBody]ServicePackReq req)
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
                var entityData = req.GetEntity();
				#region Validate
				if (!ValidateUpdate(entityData, out errorCode, out errorMessage))
				{
					return Ok(new RequestErrorCode(false, errorCode, errorMessage));
				}
				#endregion

				#region Check exist
				var obj = MemoryInfo.GetServicePack(id);
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
                var lstCommandDelete = new List<EntityCommand>();
                var lstCommand = new List<EntityCommand>();
                var lstSvPackFee = MemoryInfo.GetListServicePackFeeByField(obj.Id.ToString(), ServicePackFee.ServicePackFeeFields.IdServicePack);
                foreach (var svPackFee in lstSvPackFee)
                {
                    lstCommandDelete.Add(new EntityCommand { BaseEntity = new Entity.Entity(svPackFee), EntityAction = EntityAction.Delete });
                }
                bool isOkDone = updateEntitySql.UpdateDefault(lstCommandDelete);
                if (isOkDone)
                {
                    if (req.ListDataTemp != null)
                    {
                        foreach (var svPackFee in req.ListDataTemp)
                        {
                            lstCommand.Add(new EntityCommand { BaseEntity = new Entity.Entity(svPackFee), EntityAction = EntityAction.Insert });
                        }
                    }
                }
				lstCommand.Add(new EntityCommand { BaseEntity = new Entity.Entity(entityData), EntityAction = EntityAction.Update });
                isOkDone = updateEntitySql.UpdateDefault(lstCommand);
				if (!isOkDone)
				{
					return Ok(new RequestErrorCode(false, errorCode, errorMessage));
				}
				#endregion
				// update memory
				MemorySet.UpdateAndInsertEntity(entityData);
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

				#region Check exist
				var obj = MemoryInfo.GetServicePack(id);
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
                var lstSvPackFee = MemoryInfo.GetListServicePackFeeByField(obj.Id.ToString(), ServicePackFee.ServicePackFeeFields.IdServicePack);
                foreach (var svPackFee in lstSvPackFee)
                {
                    lstCommand.Add(new EntityCommand { BaseEntity = new Entity.Entity(svPackFee), EntityAction = EntityAction.Delete });
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
		private bool Validate(ServicePack obj, out string errorCode, out string errorMess)
		{
			errorCode = null;
			errorMess = null;
			try
			{

			}
			catch (Exception ex)
			{
				Logger.Write(ex.ToString());
				throw;
			}
			return true;
		}

		private bool ValidateUpdate(ServicePack obj, out string errorCode, out string errorMess)
		{
			errorCode = null;
			errorMess = null;
			try
			{

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

