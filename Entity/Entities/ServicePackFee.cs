using Nexus.Entity.Keys;
using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class ServicePackFee: BaseEntity
	{
		#region InnerClass

		public enum ServicePackFeeFields
		{
			IdFee,
			IdServicePack,
			Value
		}

		public enum ServicePackFeeKey
		{
			IdFee,
			IdServicePack
		}
		public ServicePackFeeKeys GetServicePackFeeKeys()
		{
			return new ServicePackFeeKeys
			{
				IdFee = IdFee,
				IdServicePack = IdServicePack
			};
		}
		#endregion

		#region Contructor

		public ServicePackFee()
		{
		}

		#endregion

		#region Properties

		public int  IdFee { get; set; } //Key 
		public int  IdServicePack { get; set; } //Key 
		public string  Value { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{

			if (Value != null && Value.Length > 255 )
				throw new InvalidDataException("Field: Value in entity: ServicePackFee is over-size: 255, value=" + Value);
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(ServicePackFee).Name;
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

