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
			CreatedAt,
			CreatedBy,
			IdFee,
			IdPayment,
			IsDeleted,
			UpdatedAt,
			UpdatedBy,
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

		public DateTime?  CreatedAt { get; set; }
		public int?  CreatedBy { get; set; }
		public int  IdFee { get; set; } //Key 
		public int  IdPayment { get; set; } //Key 
		public int?  IsDeleted { get; set; }
		public DateTime?  UpdatedAt { get; set; }
		public int?  UpdatedBy { get; set; }
		public string  Value { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{
			if (Value == null)
				throw new NoNullAllowedException("Field: Value in entity: PaymentFee is Null");

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

