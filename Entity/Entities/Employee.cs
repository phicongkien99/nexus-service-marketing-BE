using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class Employee: BaseEntity
	{
		#region InnerClass

		public enum EmployeeFields
		{
			Address,
			CreatedAt,
			Email,
			Id,
			IdStore,
			IsActivated,
			Name,
			Password,
			Phone,
			Role,
			UpdatedAt
		}

		public enum EmployeeKey
		{
			Id
		}
		#endregion

		#region Contructor

		public Employee()
		{
		}

		#endregion

		#region Properties

		public string  Address { get; set; }
		public DateTime?  CreatedAt { get; set; }
		public string  Email { get; set; }
		public int  Id { get; set; } //Key 
		public int?  IdStore { get; set; }
		public int?  IsActivated { get; set; }
		public string  Name { get; set; }
		public string  Password { get; set; }
		public string  Phone { get; set; }
		public string  Role { get; set; }
		public DateTime?  UpdatedAt { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{

			if (Address != null && Address.Length > 255 )
				throw new InvalidDataException("Field: Address in entity: Employee is over-size: 255, value=" + Address);

			if (Email != null && Email.Length > 255 )
				throw new InvalidDataException("Field: Email in entity: Employee is over-size: 255, value=" + Email);

			if (Name != null && Name.Length > 255 )
				throw new InvalidDataException("Field: Name in entity: Employee is over-size: 255, value=" + Name);

			if (Password != null && Password.Length > 255 )
				throw new InvalidDataException("Field: Password in entity: Employee is over-size: 255, value=" + Password);

			if (Phone != null && Phone.Length > 255 )
				throw new InvalidDataException("Field: Phone in entity: Employee is over-size: 255, value=" + Phone);

			if (Role != null && Role.Length > 255 )
				throw new InvalidDataException("Field: Role in entity: Employee is over-size: 255, value=" + Role);
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(Employee).Name;
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

