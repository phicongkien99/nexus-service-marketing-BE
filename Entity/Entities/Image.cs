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
			Id,
			IdCustomer,
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

		public int  Id { get; set; } //Key 
		public int?  IdCustomer { get; set; }
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

