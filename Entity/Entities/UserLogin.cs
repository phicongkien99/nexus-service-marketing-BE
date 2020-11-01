using System.Data;
using System.IO;

namespace Nexus.Entity.Entities
{
	public class UserLogin: BaseEntity
	{
		#region InnerClass

		public enum UserLoginFields
		{
			Id,
			Password,
			Username,
			UserStatus
		}

		public enum UserLoginKey
		{
			Id
		}
		#endregion

		#region Contructor

		public UserLogin()
		{
		}

		#endregion

		#region Properties

		public int  Id { get; set; } //Key 
		public string  Password { get; set; }
		public string  Username { get; set; }
		public int  UserStatus { get; set; }

		#endregion

		#region Validation

		public override bool IsValid()
		{
			if (Password == null)
				throw new NoNullAllowedException("Field: Password in entity: UserLogin is Null");

			if (Password != null && Password.Length > 255 )
				throw new InvalidDataException("Field: Password in entity: UserLogin is over-size: 255, value=" + Password);
			if (Username == null)
				throw new NoNullAllowedException("Field: Username in entity: UserLogin is Null");

			if (Username != null && Username.Length > 255 )
				throw new InvalidDataException("Field: Username in entity: UserLogin is over-size: 255, value=" + Username);
			return true;
		}

		#endregion

		#region EntityName, GetName

		public static string EntityName()
		{
			return typeof(UserLogin).Name;
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

