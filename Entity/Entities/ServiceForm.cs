using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class ServiceForm: BaseEntity
	{
		#region InnerClass

		public enum ServiceFormFields
		{
			Address,
			CreatedAt,
			CreatedBy,
			Id,
			IdArea,
			IdCustomer,
			IdEmployee,
			IdServiceFormStatus,
			IdServicePack,
			IsDeleted,
			ServiceFormId,
			UpdatedAt,
			UpdatedBy
		}

		public enum ServiceFormKey
		{
			Id
		}
		#endregion

		#region Contructor

		public ServiceForm()
		{
		}

		#endregion

		#region Properties

		public string  Address { get; set; }
		public DateTime?  CreatedAt { get; set; }
		public int?  CreatedBy { get; set; }
		public int  Id { get; set; } //Key 
		public int  IdArea { get; set; }
		public int?  IdCustomer { get; set; }
		public int?  IdEmployee { get; set; }
		public int?  IdServiceFormStatus { get; set; }
		public int  IdServicePack { get; set; }
		public int?  IsDeleted { get; set; }
		public string  ServiceFormId { get; set; }
		public DateTime?  UpdatedAt { get; set; }
		public int?  UpdatedBy { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{
			if (Address == null)
				throw new NoNullAllowedException("Field: Address in entity: ServiceForm is Null");

			if (Address != null && Address.Length > 255 )
				throw new InvalidDataException("Field: Address in entity: ServiceForm is over-size: 255, value=" + Address);

			if (ServiceFormId != null && ServiceFormId.Length > 255 )
				throw new InvalidDataException("Field: ServiceFormId in entity: ServiceForm is over-size: 255, value=" + ServiceFormId);
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(ServiceForm).Name;
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

