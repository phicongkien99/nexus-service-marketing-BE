using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class Fee: BaseEntity
	{
		#region InnerClass

		public enum FeeFields
		{
			CreatedAt,
			CreatedBy,
			Description,
			Id,
			IsDeleted,
			Name,
			UpdatedAt,
			UpdatedBy
		}

		public enum FeeKey
		{
			Id
		}
		#endregion

		#region Contructor

		public Fee()
		{
		}

		#endregion

		#region Properties

		public DateTime?  CreatedAt { get; set; }
		public int?  CreatedBy { get; set; }
		public string  Description { get; set; }
		public int  Id { get; set; } //Key 
		public int?  IsDeleted { get; set; }
		public string  Name { get; set; }
		public DateTime?  UpdatedAt { get; set; }
		public int?  UpdatedBy { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{

			if (Description != null && Description.Length > 255 )
				throw new InvalidDataException("Field: Description in entity: Fee is over-size: 255, value=" + Description);

			if (Name != null && Name.Length > 255 )
				throw new InvalidDataException("Field: Name in entity: Fee is over-size: 255, value=" + Name);
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(Fee).Name;
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

