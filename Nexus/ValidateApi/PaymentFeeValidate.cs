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
	public class PaymentFeeValidate
	{
		#region Validation
		public static bool Validate(PaymentFee obj, out string errorCode, out string errorMess)
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
				if (obj.IdFee == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdFee not allow null value";
					return false;
				}
				if (obj.IdPayment == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdPayment not allow null value";
					return false;
				}
				if (obj.Value == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Value not allow null value";
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

		public static bool ValidateUpdate(PaymentFee obj, out string errorCode, out string errorMess)
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
				if (obj.IdFee == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdFee not allow null value";
					return false;
				}
				if (obj.IdPayment == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "IdPayment not allow null value";
					return false;
				}
				if (obj.Value == null)
				{
					errorCode = ErrorCodeEnum.DataInputWrong.ToString();
					errorMess = "Value not allow null value";
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

