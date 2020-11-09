using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class Store: BaseEntity
	{
		#region InnerClass

		public enum StoreFields
		{
			Address,
			CreatedAt,
			CreatedBy,
			Id,
			IdArea,
			IsClosed,
			IsDeleted,
			Name,
			UpdatedAt,
			UpdatedBy
		}

		public enum StoreKey
		{
			Id
		}
		#endregion

		#region Contructor

		public Store()
		{
		}

		#endregion

		#region Properties

		public string  Address { get; set; }
		public DateTime?  CreatedAt { get; set; }
		public int?  CreatedBy { get; set; }
		public int  Id { get; set; } //Key 
		public int  IdArea { get; set; }
		public int?  IsClosed { get; set; }
		public int?  IsDeleted { get; set; }
		public string  Name { get; set; }
		public DateTime?  UpdatedAt { get; set; }
		public int?  UpdatedBy { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{
			if (Address == null)
				throw new NoNullAllowedException("Field: Address in entity: Store is Null");

			if (Address != null && Address.Length > 255 )
				throw new InvalidDataException("Field: Address in entity: Store is over-size: 255, value=" + Address);
			if (Name == null)
				throw new NoNullAllowedException("Field: Name in entity: Store is Null");

			if (Name != null && Name.Length > 255 )
				throw new InvalidDataException("Field: Name in entity: Store is over-size: 255, value=" + Name);
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(Store).Name;
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

