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
	public class ContractValidate
	{
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

