using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class Area: BaseEntity
	{
		#region InnerClass

		public enum AreaFields
		{
			CreatedAt,
			CreatedBy,
			Id,
			IsDeleted,
			Name,
			ShortName,
			UpdatedAt,
			UpdatedBy
		}

		public enum AreaKey
		{
			Id
		}
		#endregion

		#region Contructor

		public Area()
		{
		}

		#endregion

		#region Properties

		public DateTime?  CreatedAt { get; set; }
		public int?  CreatedBy { get; set; }
		public int  Id { get; set; } //Key 
		public int?  IsDeleted { get; set; }
		public string  Name { get; set; }
		public string  ShortName { get; set; }
		public DateTime?  UpdatedAt { get; set; }
		public int?  UpdatedBy { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{

			if (Name != null && Name.Length > 255 )
				throw new InvalidDataException("Field: Name in entity: Area is over-size: 255, value=" + Name);

			if (ShortName != null && ShortName.Length > 255 )
				throw new InvalidDataException("Field: ShortName in entity: Area is over-size: 255, value=" + ShortName);
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(Area).Name;
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

