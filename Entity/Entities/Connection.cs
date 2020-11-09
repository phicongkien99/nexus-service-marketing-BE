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
			CreatedAt,
			CreatedBy,
			Id,
			IdConnectionStatus,
			IdContract,
			IdDevice,
			IdServicePack,
			IsDeleted,
			StartDate,
			UpdatedAt,
			UpdatedBy
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

		public DateTime?  CreatedAt { get; set; }
		public int?  CreatedBy { get; set; }
		public int  Id { get; set; } //Key 
		public int?  IdConnectionStatus { get; set; }
		public int  IdContract { get; set; }
		public int  IdDevice { get; set; }
		public int  IdServicePack { get; set; }
		public int?  IsDeleted { get; set; }
		public DateTime  StartDate { get; set; }
		public DateTime?  UpdatedAt { get; set; }
		public int?  UpdatedBy { get; set; }

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

