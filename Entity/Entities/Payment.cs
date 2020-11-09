using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class Payment: BaseEntity
	{
		#region InnerClass

		public enum PaymentFields
		{
			CreatedAt,
			CreatedBy,
			Id,
			IdContract,
			IsDeleted,
			PayDate,
			TotalPrice,
			UpdatedAt,
			UpdatedBy
		}

		public enum PaymentKey
		{
			Id
		}
		#endregion

		#region Contructor

		public Payment()
		{
		}

		#endregion

		#region Properties

		public DateTime?  CreatedAt { get; set; }
		public int?  CreatedBy { get; set; }
		public int  Id { get; set; } //Key 
		public int  IdContract { get; set; }
		public int?  IsDeleted { get; set; }
		public DateTime?  PayDate { get; set; }
		public decimal?  TotalPrice { get; set; }
		public DateTime?  UpdatedAt { get; set; }
		public int?  UpdatedBy { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(Payment).Name;
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

