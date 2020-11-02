using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Nexus.Entity;
using Nexus.Entity.Entities;
using Nexus.DatabaseDAL.Common;
using System.Data;
using Anotar.NLog;

namespace Nexus.DatabaseDAL.EntitySql
{
	public class DeviceSql : EntityBaseSql 
	{

        #region Constructor

		public DeviceSql()
		{
			 Init();
		}

        #endregion
		
		#region Init

		private void Init()
		{
           Insertsql = "Device_Insert";
           Updatesql = "Device_Update";
           Deletesql = "Device_DeleteByPrimaryKey";
           Selectsql = "Device_SelectAll";
		}

        #endregion

        #region Public override Methods

        public override SqlCommand GetSqlCommandForInsert(BaseEntity baseEntity)
		{
			var sqlCommand = new SqlCommand { CommandType = CommandTypeProcedure };
            if (baseEntity != null)
            {
                var businessObject = baseEntity as Device;
                if (businessObject != null)
				{

								sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdDeviceType", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdDeviceType));
				sqlCommand.Parameters.Add(new SqlParameter("@IdManufacturer", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdManufacturer));
				sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
				sqlCommand.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Stock));
				sqlCommand.Parameters.Add(new SqlParameter("@Using", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Using));


				}
			}
            return sqlCommand;	
		}

		public override BaseEntity UpdateEntityId(BaseEntity baseEntity, SqlCommand sqlCommand)
        {
            if (baseEntity != null)
            {
                return baseEntity;
                var businessObject = baseEntity as Device;

                if (businessObject != null)
                {
                
                }
                return businessObject;
            }
            return null;
        }

        public override SqlCommand GetSqlCommandForUpdate(BaseEntity baseEntity)
        {
            var sqlCommand = new SqlCommand { CommandType = CommandTypeProcedure };
            if (baseEntity != null)
            {
                var businessObject = baseEntity as Device;

                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdDeviceType", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdDeviceType));
				sqlCommand.Parameters.Add(new SqlParameter("@IdManufacturer", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdManufacturer));
				sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
				sqlCommand.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Stock));
				sqlCommand.Parameters.Add(new SqlParameter("@Using", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Using));

				
				}
			}       
         return sqlCommand;
		}
        
        public override SqlCommand GetSqlCommandForDelete(BaseEntity baseEntity)
		{
            var sqlCommand = new SqlCommand {CommandType = CommandTypeProcedure};
            if (baseEntity != null)
            {
                var businessObject = baseEntity as Device;
                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));

				
				}
            }
            return sqlCommand;
        }
        
		public override List<BaseEntity> PopulateBusinessObjectFromReader(IDataReader dataReader)
        {
			var list = new List<BaseEntity>();
            _dicIndex = new Dictionary<string, int>();
            while (dataReader.Read())
            {
                var businessObject = new Device();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }

            return list;
		}     

        #endregion

        #region Private Methods
        public static Dictionary<string, int> _dicIndex = new Dictionary<string, int>();
	    public static void FillDicIndex(IDataReader dataReader)
	    {
	        for (int i = 0; i < dataReader.FieldCount; i++)
	        {
	            var columnName = dataReader.GetName(i);
	            _dicIndex[columnName.ToLower()] = i;
	        }
	    }
	    public static int GetIndex(string name)
	    {
	        if (_dicIndex.ContainsKey(name.ToLower()))
	            return _dicIndex[name.ToLower()];
	        //LogTo.Info("Khong tim thay column name = " + name.ToLower());
	        return -1;
	    }

    internal void PopulateBusinessObjectFromReader(Device businessObject, IDataReader dataReader)
        {
            if (_dicIndex.Count == 0) FillDicIndex(dataReader);
		
				businessObject.Id = dataReader.GetInt32(GetIndex(Device.DeviceFields.Id.ToString()));

			if (GetIndex(Device.DeviceFields.IdDeviceType.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Device.DeviceFields.IdDeviceType.ToString())))
				{
					businessObject.IdDeviceType = dataReader.GetInt32(GetIndex(Device.DeviceFields.IdDeviceType.ToString()));
				}

			if (GetIndex(Device.DeviceFields.IdManufacturer.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Device.DeviceFields.IdManufacturer.ToString())))
				{
					businessObject.IdManufacturer = dataReader.GetInt32(GetIndex(Device.DeviceFields.IdManufacturer.ToString()));
				}

			if (GetIndex(Device.DeviceFields.Name.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Device.DeviceFields.Name.ToString())))
				{
					businessObject.Name = dataReader.GetString(GetIndex(Device.DeviceFields.Name.ToString()));
				}

			if (GetIndex(Device.DeviceFields.Stock.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Device.DeviceFields.Stock.ToString())))
				{
					businessObject.Stock = dataReader.GetInt32(GetIndex(Device.DeviceFields.Stock.ToString()));
				}

			if (GetIndex(Device.DeviceFields.Using.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Device.DeviceFields.Using.ToString())))
				{
					businessObject.Using = dataReader.GetInt32(GetIndex(Device.DeviceFields.Using.ToString()));
				}


        }

        #endregion
	}
}
