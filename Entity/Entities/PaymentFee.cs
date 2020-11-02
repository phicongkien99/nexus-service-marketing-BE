using Nexus.Entity.Keys;
using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class PaymentFee: BaseEntity
	{
		#region InnerClass

		public enum PaymentFeeFields
		{
			IdFee,
			IdPayment,
			Value
		}

		public enum PaymentFeeKey
		{
			IdFee,
			IdPayment
		}
		public PaymentFeeKeys GetPaymentFeeKeys()
		{
			return new PaymentFeeKeys
			{
				IdFee = IdFee,
				IdPayment = IdPayment
			};
		}
		#endregion

		#region Contructor

		public PaymentFee()
		{
		}

		#endregion

		#region Properties

		public int  IdFee { get; set; } //Key 
		public int  IdPayment { get; set; } //Key 
		public string  Value { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{

			if (Value != null && Value.Length > 255 )
				throw new InvalidDataException("Field: Value in entity: PaymentFee is over-size: 255, value=" + Value);
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(PaymentFee).Name;
		}

		public override string GetName()
		{
			return EntityName();
		}

		#endregion

#region Custom Method
#endregion


	}
}

