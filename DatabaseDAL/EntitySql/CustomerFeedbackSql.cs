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
	public class CustomerFeedbackSql : EntityBaseSql 
	{

        #region Constructor

		public CustomerFeedbackSql()
		{
			 Init();
		}

        #endregion
		
		#region Init

		private void Init()
		{
           Insertsql = "CustomerFeedback_Insert";
           Updatesql = "CustomerFeedback_Update";
           Deletesql = "CustomerFeedback_DeleteByPrimaryKey";
           Selectsql = "CustomerFeedback_SelectAll";
		}

        #endregion

        #region Public override Methods

        public override SqlCommand GetSqlCommandForInsert(BaseEntity baseEntity)
		{
			var sqlCommand = new SqlCommand { CommandType = CommandTypeProcedure };
            if (baseEntity != null)
            {
                var businessObject = baseEntity as CustomerFeedback;
                if (businessObject != null)
				{

								sqlCommand.Parameters.Add(new SqlParameter("@Content", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Content));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdCustomer", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdCustomer));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDeleted", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDeleted));
				sqlCommand.Parameters.Add(new SqlParameter("@Rating", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Rating));
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
                var businessObject = baseEntity as CustomerFeedback;

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
                var businessObject = baseEntity as CustomerFeedback;

                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@Content", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Content));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdCustomer", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdCustomer));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDeleted", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDeleted));
				sqlCommand.Parameters.Add(new SqlParameter("@Rating", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Rating));
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
                var businessObject = baseEntity as CustomerFeedback;
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
                var businessObject = new CustomerFeedback();
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

    internal void PopulateBusinessObjectFromReader(CustomerFeedback businessObject, IDataReader dataReader)
        {
            if (_dicIndex.Count == 0) FillDicIndex(dataReader);
		
			if (GetIndex(CustomerFeedback.CustomerFeedbackFields.Content.ToString()) != -1)
				businessObject.Content = dataReader.GetString(GetIndex(CustomerFeedback.CustomerFeedbackFields.Content.ToString()));

			if (GetIndex(CustomerFeedback.CustomerFeedbackFields.CreatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(CustomerFeedback.CustomerFeedbackFields.CreatedAt.ToString())))
				{
					businessObject.CreatedAt = dataReader.GetDateTime(GetIndex(CustomerFeedback.CustomerFeedbackFields.CreatedAt.ToString()));
				}

			if (GetIndex(CustomerFeedback.CustomerFeedbackFields.CreatedBy.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(CustomerFeedback.CustomerFeedbackFields.CreatedBy.ToString())))
				{
					businessObject.CreatedBy = dataReader.GetInt32(GetIndex(CustomerFeedback.CustomerFeedbackFields.CreatedBy.ToString()));
				}

				businessObject.Id = dataReader.GetInt32(GetIndex(CustomerFeedback.CustomerFeedbackFields.Id.ToString()));

			if (GetIndex(CustomerFeedback.CustomerFeedbackFields.IdCustomer.ToString()) != -1)
				businessObject.IdCustomer = dataReader.GetInt32(GetIndex(CustomerFeedback.CustomerFeedbackFields.IdCustomer.ToString()));

			if (GetIndex(CustomerFeedback.CustomerFeedbackFields.IsDeleted.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(CustomerFeedback.CustomerFeedbackFields.IsDeleted.ToString())))
				{
					businessObject.IsDeleted = dataReader.GetInt32(GetIndex(CustomerFeedback.CustomerFeedbackFields.IsDeleted.ToString()));
				}

			if (GetIndex(CustomerFeedback.CustomerFeedbackFields.Rating.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(CustomerFeedback.CustomerFeedbackFields.Rating.ToString())))
				{
					businessObject.Rating = dataReader.GetInt32(GetIndex(CustomerFeedback.CustomerFeedbackFields.Rating.ToString()));
				}

			if (GetIndex(CustomerFeedback.CustomerFeedbackFields.UpdatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(CustomerFeedback.CustomerFeedbackFields.UpdatedAt.ToString())))
				{
					businessObject.UpdatedAt = dataReader.GetDateTime(GetIndex(CustomerFeedback.CustomerFeedbackFields.UpdatedAt.ToString()));
				}

			if (GetIndex(CustomerFeedback.CustomerFeedbackFields.UpdatedBy.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(CustomerFeedback.CustomerFeedbackFields.UpdatedBy.ToString())))
				{
					businessObject.UpdatedBy = dataReader.GetInt32(GetIndex(CustomerFeedback.CustomerFeedbackFields.UpdatedBy.ToString()));
				}


        }

        #endregion
	}
}
