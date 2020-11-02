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
			Id,
			IdContract,
			PayDate,
			TotalPrice
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

		public int  Id { get; set; } //Key 
		public int?  IdContract { get; set; }
		public DateTime?  PayDate { get; set; }
		public decimal?  TotalPrice { get; set; }

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

