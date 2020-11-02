using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class Contract: BaseEntity
	{
		#region InnerClass

		public enum ContractFields
		{
			Address,
			ContractId,
			CreatedDate,
			Id,
			IdArea,
			IdCustomer,
			NextPayment
		}

		public enum ContractKey
		{
			Id
		}
		#endregion

		#region Contructor

		public Contract()
		{
		}

		#endregion

		#region Properties

		public string  Address { get; set; }
		public string  ContractId { get; set; }
		public DateTime?  CreatedDate { get; set; }
		public int  Id { get; set; } //Key 
		public int?  IdArea { get; set; }
		public int?  IdCustomer { get; set; }
		public DateTime?  NextPayment { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{

			if (Address != null && Address.Length > 255 )
				throw new InvalidDataException("Field: Address in entity: Contract is over-size: 255, value=" + Address);

			if (ContractId != null && ContractId.Length > 45 )
				throw new InvalidDataException("Field: ContractId in entity: Contract is over-size: 45, value=" + ContractId);
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(Contract).Name;
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

