using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class Image: BaseEntity
	{
		#region InnerClass

		public enum ImageFields
		{
			CreatedAt,
			CreatedBy,
			Id,
			IdCustomer,
			IsDeleted,
			UpdatedAt,
			UpdatedBy,
			Url
		}

		public enum ImageKey
		{
			Id
		}
		#endregion

		#region Contructor

		public Image()
		{
		}

		#endregion

		#region Properties

		public DateTime?  CreatedAt { get; set; }
		public int?  CreatedBy { get; set; }
		public int  Id { get; set; } //Key 
		public int?  IdCustomer { get; set; }
		public int?  IsDeleted { get; set; }
		public DateTime?  UpdatedAt { get; set; }
		public int?  UpdatedBy { get; set; }
		public string  Url { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{

			if (Url != null && Url.Length > 255 )
				throw new InvalidDataException("Field: Url in entity: Image is over-size: 255, value=" + Url);
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(Image).Name;
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

