using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class ServicePack: BaseEntity
	{
		#region InnerClass

		public enum ServicePackFields
		{
			CreatedAt,
			CreatedBy,
			Description,
			Id,
			IdConnectionType,
			IsDeleted,
			Name,
			UpdatedAt,
			UpdatedBy
		}

		public enum ServicePackKey
		{
			Id
		}
		#endregion

		#region Contructor

		public ServicePack()
		{
		}

		#endregion

		#region Properties

		public DateTime?  CreatedAt { get; set; }
		public int?  CreatedBy { get; set; }
		public string  Description { get; set; }
		public int  Id { get; set; } //Key 
		public int  IdConnectionType { get; set; }
		public int?  IsDeleted { get; set; }
		public string  Name { get; set; }
		public DateTime?  UpdatedAt { get; set; }
		public int?  UpdatedBy { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{

			if (Description != null && Description.Length > 255 )
				throw new InvalidDataException("Field: Description in entity: ServicePack is over-size: 255, value=" + Description);
			if (Name == null)
				throw new NoNullAllowedException("Field: Name in entity: ServicePack is Null");

			if (Name != null && Name.Length > 255 )
				throw new InvalidDataException("Field: Name in entity: ServicePack is over-size: 255, value=" + Name);
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(ServicePack).Name;
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

