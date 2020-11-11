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
	public class ServiceFormStatusSql : EntityBaseSql 
	{

        #region Constructor

		public ServiceFormStatusSql()
		{
			 Init();
		}

        #endregion
		
		#region Init

		private void Init()
		{
           Insertsql = "ServiceFormStatus_Insert";
           Updatesql = "ServiceFormStatus_Update";
           Deletesql = "ServiceFormStatus_DeleteByPrimaryKey";
           Selectsql = "ServiceFormStatus_SelectAll";
		}

        #endregion

        #region Public override Methods

        public override SqlCommand GetSqlCommandForInsert(BaseEntity baseEntity)
		{
			var sqlCommand = new SqlCommand { CommandType = CommandTypeProcedure };
            if (baseEntity != null)
            {
                var businessObject = baseEntity as ServiceFormStatus;
                if (businessObject != null)
				{

								sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDeleted", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDeleted));
				sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
				sqlCommand.Parameters.Add(new SqlParameter("@UpdatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UpdatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@UpdatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UpdatedBy));


				}
			}
            return sqlCommand;	
		}

		public override BaseEntity UpdateEntityId(BaseEntity baseEntity, SqlCommand sqlCommand)
        {
            if (baseEntity != null)
            {
                return baseEntity;
                var businessObject = baseEntity as ServiceFormStatus;

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
                var businessObject = baseEntity as ServiceFormStatus;

                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDeleted", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDeleted));
				sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
				sqlCommand.Parameters.Add(new SqlParameter("@UpdatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UpdatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@UpdatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UpdatedBy));

				
				}
			}       
         return sqlCommand;
		}
        
        public override SqlCommand GetSqlCommandForDelete(BaseEntity baseEntity)
		{
            var sqlCommand = new SqlCommand {CommandType = CommandTypeProcedure};
            if (baseEntity != null)
            {
                var businessObject = baseEntity as ServiceFormStatus;
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
                var businessObject = new ServiceFormStatus();
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

    internal void PopulateBusinessObjectFromReader(ServiceFormStatus businessObject, IDataReader dataReader)
        {
            if (_dicIndex.Count == 0) FillDicIndex(dataReader);
		
			if (GetIndex(ServiceFormStatus.ServiceFormStatusFields.CreatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceFormStatus.ServiceFormStatusFields.CreatedAt.ToString())))
				{
					businessObject.CreatedAt = dataReader.GetDateTime(GetIndex(ServiceFormStatus.ServiceFormStatusFields.CreatedAt.ToString()));
				}

			if (GetIndex(ServiceFormStatus.ServiceFormStatusFields.CreatedBy.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceFormStatus.ServiceFormStatusFields.CreatedBy.ToString())))
				{
					businessObject.CreatedBy = dataReader.GetInt32(GetIndex(ServiceFormStatus.ServiceFormStatusFields.CreatedBy.ToString()));
				}

			if (GetIndex(ServiceFormStatus.ServiceFormStatusFields.Description.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceFormStatus.ServiceFormStatusFields.Description.ToString())))
				{
					businessObject.Description = dataReader.GetString(GetIndex(ServiceFormStatus.ServiceFormStatusFields.Description.ToString()));
				}

				businessObject.Id = dataReader.GetInt32(GetIndex(ServiceFormStatus.ServiceFormStatusFields.Id.ToString()));

			if (GetIndex(ServiceFormStatus.ServiceFormStatusFields.IsDeleted.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceFormStatus.ServiceFormStatusFields.IsDeleted.ToString())))
				{
					businessObject.IsDeleted = dataReader.GetInt32(GetIndex(ServiceFormStatus.ServiceFormStatusFields.IsDeleted.ToString()));
				}

			if (GetIndex(ServiceFormStatus.ServiceFormStatusFields.Name.ToString()) != -1)
				businessObject.Name = dataReader.GetString(GetIndex(ServiceFormStatus.ServiceFormStatusFields.Name.ToString()));

			if (GetIndex(ServiceFormStatus.ServiceFormStatusFields.UpdatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceFormStatus.ServiceFormStatusFields.UpdatedAt.ToString())))
				{
					businessObject.UpdatedAt = dataReader.GetDateTime(GetIndex(ServiceFormStatus.ServiceFormStatusFields.UpdatedAt.ToString()));
				}

			if (GetIndex(ServiceFormStatus.ServiceFormStatusFields.UpdatedBy.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceFormStatus.ServiceFormStatusFields.UpdatedBy.ToString())))
				{
					businessObject.UpdatedBy = dataReader.GetInt32(GetIndex(ServiceFormStatus.ServiceFormStatusFields.UpdatedBy.ToString()));
				}


        }

        #endregion
	}
}
