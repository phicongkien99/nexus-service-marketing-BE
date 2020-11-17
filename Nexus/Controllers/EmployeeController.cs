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
	public class EmployeeController: ApiController
	{
		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public async Task<IHttpActionResult> Get()
		{
			try
			{
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
				var lstData = MemoryInfo.GetAllEmployee();
                foreach (var item in lstData)
                {
                    item.Password = null;
                    if (item.IsDeleted == 1)
                        lstData.Remove(item);
					
                }
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
				var data = MemoryInfo.GetEmployee(id);
                data.Password = null;
                if (data.IsDeleted == 1)
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
		public async Task<IHttpActionResult> Post([FromBody]Employee req)
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

                if (employee == null || employee.Role != RoleDefinitionEnum.admin.ToString())
                {
                    return Ok(new RequestErrorCode(false, ErrorCodeEnum.Error_NotHavePermision.ToString(), "Khong co quyen tao user"));
				}
				#endregion

				#region Validate
				if (!Validate(req, out errorCode, out errorMessage))
				{
					return Ok(new RequestErrorCode(false, errorCode, errorMessage));
				}
				#endregion

				#region Tạo key
				var oldKey = Memory.Memory.GetMaxKey(req.GetName());
				int newKey = oldKey + 1;
				// set key
				req.Id = newKey;
				#endregion

				#region Process
				req.CreatedAt = DateTime.Now;
				req.CreatedBy = employee.Id;
				req.IsDeleted = 0;
                req.Password = PasswordGenerator.EncodePassword(req.Password);
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
		public async Task<IHttpActionResult> Put(int id,[FromBody]Employee req)
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

				#region Validate
				if (!ValidateUpdate(req, out errorCode, out errorMessage))
				{
					return Ok(new RequestErrorCode(false, errorCode, errorMessage));
				}
				#endregion

				#region Check exist
				var obj = MemoryInfo.GetEmployee(id);
				if (obj == null)
				{
					return Ok(new RequestErrorCode(false, ErrorCodeEnum.DataNotExist.ToString(), "Khong ton tai"));
				}
				#endregion
				req.Id = obj.Id; // gan lai id de update
				#region Process
				req.UpdatedAt = DateTime.Now;
				req.UpdatedBy = employee.Id;
                req.Password = PasswordGenerator.EncodePassword(req.Password);
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

				#region Check exist
				var obj = MemoryInfo.GetEmployee(id);
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
		public static bool Validate(Employee obj, out string errorCode, out string errorMess)
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
				if (obj.Email == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Email not allow null value";
					return false;
				}
				if (obj.IdStore == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdStore not allow null value";
					return false;
				}
				if (obj.Name == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Name not allow null value";
					return false;
				}
				if (obj.Password == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Password not allow null value";
					return false;
				}
				if (obj.Phone == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Phone not allow null value";
					return false;
				}
				if (obj.Role == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Role not allow null value";
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

		public static bool ValidateUpdate(Employee obj, out string errorCode, out string errorMess)
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
				if (obj.Email == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Email not allow null value";
					return false;
				}
				if (obj.IdStore == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdStore not allow null value";
					return false;
				}
				if (obj.Name == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Name not allow null value";
					return false;
				}
				if (obj.Password == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Password not allow null value";
					return false;
				}
				if (obj.Phone == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Phone not allow null value";
					return false;
				}
				if (obj.Role == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Role not allow null value";
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

