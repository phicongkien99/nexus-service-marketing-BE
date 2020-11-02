using System;using System.IO;
using System.Text;
using System.Data;

namespace Nexus.Entity.Entities
{
	public class Connection: BaseEntity
	{
		#region InnerClass

		public enum ConnectionFields
		{
			Id,
			IdConnectionStatus,
			IdContract,
			IdDevice,
			IdServicePack,
			StartDate
		}

		public enum ConnectionKey
		{
			Id
		}
		#endregion

		#region Contructor

		public Connection()
		{
		}

		#endregion

		#region Properties

		public int  Id { get; set; } //Key 
		public int?  IdConnectionStatus { get; set; }
		public int?  IdContract { get; set; }
		public int?  IdDevice { get; set; }
		public int?  IdServicePack { get; set; }
		public DateTime?  StartDate { get; set; }

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
			return typeof(Connection).Name;
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

