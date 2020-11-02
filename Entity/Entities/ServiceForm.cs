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
			Id,
			IdCustomer,
			IdEmployee,
			IdServiceFormStatus,
			IdServicePack
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

		public int  Id { get; set; } //Key 
		public int?  IdCustomer { get; set; }
		public int?  IdEmployee { get; set; }
		public int?  IdServiceFormStatus { get; set; }
		public int?  IdServicePack { get; set; }

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

