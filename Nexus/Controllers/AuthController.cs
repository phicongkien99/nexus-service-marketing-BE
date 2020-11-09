using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using Nexus;
using Nexus.Common.Enum;
using Nexus.Entity.Entities;
using Nexus.Memory;
using Nexus.Models;
using Nexus.Models.Request;
using Nexus.Models.Response;
using Nexus.Utils;

namespace ElectricShop.Controllers
{
    public class AuthController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public async Task<IHttpActionResult> Post([FromBody] UserLogin req)
        {
            try
            {
                #region Validate
                string errorMessage = "UnknowError";
                string errorCode = ErrorCodeEnum.UnknownError.ToString();
                if (!Validate(req, out errorCode, out errorMessage))
                {
                    return Ok(new RequestErrorCode(false, errorCode, errorMessage));
                }
                #endregion
                // check ton tai tai khoan
                var userLogin = MemoryInfo.GetListEmployeeByField(req.Email, Employee.EmployeeFields.Email).FirstOrDefault(x => x.Email == req.Email);
                if (userLogin == null)
                {
                    return Ok(new RequestErrorCode(false, ErrorCodeEnum.Error_UserNotExist.ToString(), "Khong ton tai tai khoan"));
                }
                var passEncrypt = PasswordGenerator.EncodePassword(req.Password);
                if (userLogin.Password != passEncrypt)
                {
                    return Ok(new RequestErrorCode(false, ErrorCodeEnum.Error_PasswordWrong.ToString(), "Sai password"));
                }

                var userInfo = MemoryInfo.GetEmployee(userLogin.Id);
                if (userInfo == null)
                {
                    return Ok(new RequestErrorCode(false, ErrorCodeEnum.Error_UserinfoIsNull.ToString(), "Khong co thong tin Userinfo"));
                }

                #region Gen token va tra userInfo ve kem voi list quyen

                //var lstPermission = MemoryInfo.GetListPermission(userInfo.IdUserLogin);
                var token = TokenManager.GenerateToken(userInfo, -1);
                var tokenRes = new TokenResponse(token,userInfo);
                //tokenRes.ListPermission.AddRange(lstPermission);
                #endregion
                var result = new RequestErrorCode(true);
                result.ListDataResult.Add(tokenRes);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Logger.Write(ex.ToString());
            }

            Logger.Write("--------------------ErrorCodeEnum.Unknow---------------------------------");
            return BadRequest("Unknow");
        }

        #region Custom Function

        private bool Validate(UserLogin userLogin , out string errorCode, out string errorMess)
        {
            errorCode = null;
            errorMess = null;
            try
            {
                if (string.IsNullOrEmpty(userLogin.Email))
                {
                    errorMess = "Email is null";
                    errorCode = ErrorCodeEnum.Error_UsernameIsNull.ToString();
                    return false;
                }

                if (!CheckUtils.ContainsUnicodeCharacter(userLogin.Email))
                {
                    errorMess = "Username không được nhập Tiếng Việt có dấu, khoảng trắng, ký tự đặc biệt";
                    errorCode = ErrorCodeEnum.Error_UsernameIsNull.ToString();
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
