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
			CreatedAt,
			CreatedBy,
			IdFee,
			IdServicePack,
			IsDeleted,
			UpdatedAt,
			UpdatedBy,
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

		public DateTime?  CreatedAt { get; set; }
		public int?  CreatedBy { get; set; }
		public int  IdFee { get; set; } //Key 
		public int  IdServicePack { get; set; } //Key 
		public int?  IsDeleted { get; set; }
		public DateTime?  UpdatedAt { get; set; }
		public int?  UpdatedBy { get; set; }
		public string  Value { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{
			if (Value == null)
				throw new NoNullAllowedException("Field: Value in entity: ServicePackFee is Null");

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

