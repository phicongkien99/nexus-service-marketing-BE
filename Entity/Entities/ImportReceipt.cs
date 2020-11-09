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
			CreatedAt,
			CreatedBy,
			Id,
			IdProvider,
			ImportDate,
			IsDeleted,
			TotalPrice,
			UpdatedAt,
			UpdatedBy
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

		public DateTime?  CreatedAt { get; set; }
		public int?  CreatedBy { get; set; }
		public int  Id { get; set; } //Key 
		public int  IdProvider { get; set; }
		public DateTime  ImportDate { get; set; }
		public int?  IsDeleted { get; set; }
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

