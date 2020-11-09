using Nexus.Entity.Keys;
using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class DetailImportReceipt: BaseEntity
	{
		#region InnerClass

		public enum DetailImportReceiptFields
		{
			CreatedAt,
			CreatedBy,
			IdDevice,
			IdImportReceipt,
			IsDeleted,
			Price,
			Quantity,
			UpdatedAt,
			UpdatedBy
		}

		public enum DetailImportReceiptKey
		{
			IdDevice,
			IdImportReceipt
		}
		public DetailImportReceiptKeys GetDetailImportReceiptKeys()
		{
			return new DetailImportReceiptKeys
			{
				IdDevice = IdDevice,
				IdImportReceipt = IdImportReceipt
			};
		}
		#endregion

		#region Contructor

		public DetailImportReceipt()
		{
		}

		#endregion

		#region Properties

		public DateTime?  CreatedAt { get; set; }
		public int?  CreatedBy { get; set; }
		public int  IdDevice { get; set; } //Key 
		public int  IdImportReceipt { get; set; } //Key 
		public int?  IsDeleted { get; set; }
		public decimal?  Price { get; set; }
		public int?  Quantity { get; set; }
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
			return typeof(DetailImportReceipt).Name;
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

