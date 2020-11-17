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
namespace Nexus.ValidateApi
{
	public class ConnectionValidate
	{
		#region Validation
		public static bool Validate(Connection obj, out string errorCode, out string errorMess)
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
				if (obj.IdDevice == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdDevice not allow null value";
					return false;
				}
				if (obj.IdServicePack == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdServicePack not allow null value";
					return false;
				}
				if (obj.StartDate == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "StartDate not allow null value";
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

		public static bool ValidateUpdate(Connection obj, out string errorCode, out string errorMess)
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
				if (obj.IdDevice == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdDevice not allow null value";
					return false;
				}
				if (obj.IdServicePack == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdServicePack not allow null value";
					return false;
				}
				if (obj.StartDate == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "StartDate not allow null value";
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

