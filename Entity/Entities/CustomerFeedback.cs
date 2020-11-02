using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class CustomerFeedback: BaseEntity
	{
		#region InnerClass

		public enum CustomerFeedbackFields
		{
			Content,
			CreatedAt,
			Id,
			IdCustomer,
			Rating
		}

		public enum CustomerFeedbackKey
		{
			Id
		}
		#endregion

		#region Contructor

		public CustomerFeedback()
		{
		}

		#endregion

		#region Properties

		public string  Content { get; set; }
		public DateTime?  CreatedAt { get; set; }
		public int  Id { get; set; } //Key 
		public int  IdCustomer { get; set; }
		public int?  Rating { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{

			if (Content != null && Content.Length > 255 )
				throw new InvalidDataException("Field: Content in entity: CustomerFeedback is over-size: 255, value=" + Content);
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(CustomerFeedback).Name;
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

