using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class Device: BaseEntity
	{
		#region InnerClass

		public enum DeviceFields
		{
			CreatedAt,
			CreatedBy,
			Id,
			IdDeviceType,
			IdManufacturer,
			IsDeleted,
			Name,
			Stock,
			UpdatedAt,
			UpdatedBy,
			Using
		}

		public enum DeviceKey
		{
			Id
		}
		#endregion

		#region Contructor

		public Device()
		{
		}

		#endregion

		#region Properties

		public DateTime?  CreatedAt { get; set; }
		public int?  CreatedBy { get; set; }
		public int  Id { get; set; } //Key 
		public int  IdDeviceType { get; set; }
		public int  IdManufacturer { get; set; }
		public int?  IsDeleted { get; set; }
		public string  Name { get; set; }
		public int?  Stock { get; set; }
		public DateTime?  UpdatedAt { get; set; }
		public int?  UpdatedBy { get; set; }
		public int?  Using { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{
			if (Name == null)
				throw new NoNullAllowedException("Field: Name in entity: Device is Null");

			if (Name != null && Name.Length > 255 )
				throw new InvalidDataException("Field: Name in entity: Device is over-size: 255, value=" + Name);
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(Device).Name;
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

