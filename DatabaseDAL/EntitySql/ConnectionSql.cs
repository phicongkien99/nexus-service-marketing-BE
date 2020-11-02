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
	public class ConnectionSql : EntityBaseSql 
	{

        #region Constructor

		public ConnectionSql()
		{
			 Init();
		}

        #endregion
		
		#region Init

		private void Init()
		{
           Insertsql = "Connection_Insert";
           Updatesql = "Connection_Update";
           Deletesql = "Connection_DeleteByPrimaryKey";
           Selectsql = "Connection_SelectAll";
		}

        #endregion

        #region Public override Methods

        public override SqlCommand GetSqlCommandForInsert(BaseEntity baseEntity)
		{
			var sqlCommand = new SqlCommand { CommandType = CommandTypeProcedure };
            if (baseEntity != null)
            {
                var businessObject = baseEntity as Connection;
                if (businessObject != null)
				{

								sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdConnectionStatus", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdConnectionStatus));
				sqlCommand.Parameters.Add(new SqlParameter("@IdContract", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdContract));
				sqlCommand.Parameters.Add(new SqlParameter("@IdDevice", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdDevice));
				sqlCommand.Parameters.Add(new SqlParameter("@IdServicePack", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdServicePack));
				sqlCommand.Parameters.Add(new SqlParameter("@StartDate", SqlDbType.Text, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.StartDate));


				}
			}
            return sqlCommand;	
		}

		public override BaseEntity UpdateEntityId(BaseEntity baseEntity, SqlCommand sqlCommand)
        {
            if (baseEntity != null)
            {
                return baseEntity;
                var businessObject = baseEntity as Connection;

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
                var businessObject = baseEntity as Connection;

                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdConnectionStatus", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdConnectionStatus));
				sqlCommand.Parameters.Add(new SqlParameter("@IdContract", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdContract));
				sqlCommand.Parameters.Add(new SqlParameter("@IdDevice", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdDevice));
				sqlCommand.Parameters.Add(new SqlParameter("@IdServicePack", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdServicePack));
				sqlCommand.Parameters.Add(new SqlParameter("@StartDate", SqlDbType.Text, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.StartDate));

				
				}
			}       
         return sqlCommand;
		}
        
        public override SqlCommand GetSqlCommandForDelete(BaseEntity baseEntity)
		{
            var sqlCommand = new SqlCommand {CommandType = CommandTypeProcedure};
            if (baseEntity != null)
            {
                var businessObject = baseEntity as Connection;
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
                var businessObject = new Connection();
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

    internal void PopulateBusinessObjectFromReader(Connection businessObject, IDataReader dataReader)
        {
            if (_dicIndex.Count == 0) FillDicIndex(dataReader);
		
				businessObject.Id = dataReader.GetInt32(GetIndex(Connection.ConnectionFields.Id.ToString()));

			if (GetIndex(Connection.ConnectionFields.IdConnectionStatus.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Connection.ConnectionFields.IdConnectionStatus.ToString())))
				{
					businessObject.IdConnectionStatus = dataReader.GetInt32(GetIndex(Connection.ConnectionFields.IdConnectionStatus.ToString()));
				}

			if (GetIndex(Connection.ConnectionFields.IdContract.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Connection.ConnectionFields.IdContract.ToString())))
				{
					businessObject.IdContract = dataReader.GetInt32(GetIndex(Connection.ConnectionFields.IdContract.ToString()));
				}

			if (GetIndex(Connection.ConnectionFields.IdDevice.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Connection.ConnectionFields.IdDevice.ToString())))
				{
					businessObject.IdDevice = dataReader.GetInt32(GetIndex(Connection.ConnectionFields.IdDevice.ToString()));
				}

			if (GetIndex(Connection.ConnectionFields.IdServicePack.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Connection.ConnectionFields.IdServicePack.ToString())))
				{
					businessObject.IdServicePack = dataReader.GetInt32(GetIndex(Connection.ConnectionFields.IdServicePack.ToString()));
				}

			if (GetIndex(Connection.ConnectionFields.StartDate.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Connection.ConnectionFields.StartDate.ToString())))
				{
					businessObject.StartDate = dataReader.GetDateTime(GetIndex(Connection.ConnectionFields.StartDate.ToString()));
				}


        }

        #endregion
	}
}
