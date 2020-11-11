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
	public class ServiceFormSql : EntityBaseSql 
	{

        #region Constructor

		public ServiceFormSql()
		{
			 Init();
		}

        #endregion
		
		#region Init

		private void Init()
		{
           Insertsql = "ServiceForm_Insert";
           Updatesql = "ServiceForm_Update";
           Deletesql = "ServiceForm_DeleteByPrimaryKey";
           Selectsql = "ServiceForm_SelectAll";
		}

        #endregion

        #region Public override Methods

        public override SqlCommand GetSqlCommandForInsert(BaseEntity baseEntity)
		{
			var sqlCommand = new SqlCommand { CommandType = CommandTypeProcedure };
            if (baseEntity != null)
            {
                var businessObject = baseEntity as ServiceForm;
                if (businessObject != null)
				{

								sqlCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Address));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdArea", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdArea));
				sqlCommand.Parameters.Add(new SqlParameter("@IdCustomer", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdCustomer));
				sqlCommand.Parameters.Add(new SqlParameter("@IdEmployee", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdEmployee));
				sqlCommand.Parameters.Add(new SqlParameter("@IdServiceFormStatus", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdServiceFormStatus));
				sqlCommand.Parameters.Add(new SqlParameter("@IdServicePack", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdServicePack));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDeleted", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDeleted));
				sqlCommand.Parameters.Add(new SqlParameter("@ServiceFormId", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ServiceFormId));
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
                var businessObject = baseEntity as ServiceForm;

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
                var businessObject = baseEntity as ServiceForm;

                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Address));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdArea", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdArea));
				sqlCommand.Parameters.Add(new SqlParameter("@IdCustomer", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdCustomer));
				sqlCommand.Parameters.Add(new SqlParameter("@IdEmployee", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdEmployee));
				sqlCommand.Parameters.Add(new SqlParameter("@IdServiceFormStatus", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdServiceFormStatus));
				sqlCommand.Parameters.Add(new SqlParameter("@IdServicePack", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdServicePack));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDeleted", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDeleted));
				sqlCommand.Parameters.Add(new SqlParameter("@ServiceFormId", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ServiceFormId));
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
                var businessObject = baseEntity as ServiceForm;
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
                var businessObject = new ServiceForm();
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

    internal void PopulateBusinessObjectFromReader(ServiceForm businessObject, IDataReader dataReader)
        {
            if (_dicIndex.Count == 0) FillDicIndex(dataReader);
		
			if (GetIndex(ServiceForm.ServiceFormFields.Address.ToString()) != -1)
				businessObject.Address = dataReader.GetString(GetIndex(ServiceForm.ServiceFormFields.Address.ToString()));

			if (GetIndex(ServiceForm.ServiceFormFields.CreatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceForm.ServiceFormFields.CreatedAt.ToString())))
				{
					businessObject.CreatedAt = dataReader.GetDateTime(GetIndex(ServiceForm.ServiceFormFields.CreatedAt.ToString()));
				}

			if (GetIndex(ServiceForm.ServiceFormFields.CreatedBy.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceForm.ServiceFormFields.CreatedBy.ToString())))
				{
					businessObject.CreatedBy = dataReader.GetInt32(GetIndex(ServiceForm.ServiceFormFields.CreatedBy.ToString()));
				}

				businessObject.Id = dataReader.GetInt32(GetIndex(ServiceForm.ServiceFormFields.Id.ToString()));

			if (GetIndex(ServiceForm.ServiceFormFields.IdArea.ToString()) != -1)
				businessObject.IdArea = dataReader.GetInt32(GetIndex(ServiceForm.ServiceFormFields.IdArea.ToString()));

			if (GetIndex(ServiceForm.ServiceFormFields.IdCustomer.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceForm.ServiceFormFields.IdCustomer.ToString())))
				{
					businessObject.IdCustomer = dataReader.GetInt32(GetIndex(ServiceForm.ServiceFormFields.IdCustomer.ToString()));
				}

			if (GetIndex(ServiceForm.ServiceFormFields.IdEmployee.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceForm.ServiceFormFields.IdEmployee.ToString())))
				{
					businessObject.IdEmployee = dataReader.GetInt32(GetIndex(ServiceForm.ServiceFormFields.IdEmployee.ToString()));
				}

			if (GetIndex(ServiceForm.ServiceFormFields.IdServiceFormStatus.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceForm.ServiceFormFields.IdServiceFormStatus.ToString())))
				{
					businessObject.IdServiceFormStatus = dataReader.GetInt32(GetIndex(ServiceForm.ServiceFormFields.IdServiceFormStatus.ToString()));
				}

			if (GetIndex(ServiceForm.ServiceFormFields.IdServicePack.ToString()) != -1)
				businessObject.IdServicePack = dataReader.GetInt32(GetIndex(ServiceForm.ServiceFormFields.IdServicePack.ToString()));

			if (GetIndex(ServiceForm.ServiceFormFields.IsDeleted.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceForm.ServiceFormFields.IsDeleted.ToString())))
				{
					businessObject.IsDeleted = dataReader.GetInt32(GetIndex(ServiceForm.ServiceFormFields.IsDeleted.ToString()));
				}

			if (GetIndex(ServiceForm.ServiceFormFields.ServiceFormId.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceForm.ServiceFormFields.ServiceFormId.ToString())))
				{
					businessObject.ServiceFormId = dataReader.GetString(GetIndex(ServiceForm.ServiceFormFields.ServiceFormId.ToString()));
				}

			if (GetIndex(ServiceForm.ServiceFormFields.UpdatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceForm.ServiceFormFields.UpdatedAt.ToString())))
				{
					businessObject.UpdatedAt = dataReader.GetDateTime(GetIndex(ServiceForm.ServiceFormFields.UpdatedAt.ToString()));
				}

			if (GetIndex(ServiceForm.ServiceFormFields.UpdatedBy.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServiceForm.ServiceFormFields.UpdatedBy.ToString())))
				{
					businessObject.UpdatedBy = dataReader.GetInt32(GetIndex(ServiceForm.ServiceFormFields.UpdatedBy.ToString()));
				}


        }

        #endregion
	}
}
