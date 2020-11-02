using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class ImportReceipt: BaseEntity
	{
		#region InnerClass

		public enum ImportReceiptFields
		{
			Id,
			IdProvider,
			ImportDate,
			TotalPrice
		}

		public enum ImportReceiptKey
		{
			Id
		}
		#endregion

		#region Contructor

		public ImportReceipt()
		{
		}

		#endregion

		#region Properties

		public int  Id { get; set; } //Key 
		public int  IdProvider { get; set; }
		public DateTime?  ImportDate { get; set; }
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
			return typeof(ImportReceipt).Name;
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

