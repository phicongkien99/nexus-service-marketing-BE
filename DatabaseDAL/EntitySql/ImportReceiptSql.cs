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
	public class ImportReceiptSql : EntityBaseSql 
	{

        #region Constructor

		public ImportReceiptSql()
		{
			 Init();
		}

        #endregion
		
		#region Init

		private void Init()
		{
           Insertsql = "ImportReceipt_Insert";
           Updatesql = "ImportReceipt_Update";
           Deletesql = "ImportReceipt_DeleteByPrimaryKey";
           Selectsql = "ImportReceipt_SelectAll";
		}

        #endregion

        #region Public override Methods

        public override SqlCommand GetSqlCommandForInsert(BaseEntity baseEntity)
		{
			var sqlCommand = new SqlCommand { CommandType = CommandTypeProcedure };
            if (baseEntity != null)
            {
                var businessObject = baseEntity as ImportReceipt;
                if (businessObject != null)
				{

								sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdProvider", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdProvider));
				sqlCommand.Parameters.Add(new SqlParameter("@ImportDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ImportDate));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDeleted", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDeleted));
				sqlCommand.Parameters.Add(new SqlParameter("@TotalPrice", SqlDbType.Decimal, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TotalPrice));
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
                var businessObject = baseEntity as ImportReceipt;

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
                var businessObject = baseEntity as ImportReceipt;

                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdProvider", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdProvider));
				sqlCommand.Parameters.Add(new SqlParameter("@ImportDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ImportDate));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDeleted", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDeleted));
				sqlCommand.Parameters.Add(new SqlParameter("@TotalPrice", SqlDbType.Decimal, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TotalPrice));
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
                var businessObject = baseEntity as ImportReceipt;
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
                var businessObject = new ImportReceipt();
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

    internal void PopulateBusinessObjectFromReader(ImportReceipt businessObject, IDataReader dataReader)
        {
            if (_dicIndex.Count == 0) FillDicIndex(dataReader);
		
			if (GetIndex(ImportReceipt.ImportReceiptFields.CreatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ImportReceipt.ImportReceiptFields.CreatedAt.ToString())))
				{
					businessObject.CreatedAt = dataReader.GetDateTime(GetIndex(ImportReceipt.ImportReceiptFields.CreatedAt.ToString()));
				}

			if (GetIndex(ImportReceipt.ImportReceiptFields.CreatedBy.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ImportReceipt.ImportReceiptFields.CreatedBy.ToString())))
				{
					businessObject.CreatedBy = dataReader.GetInt32(GetIndex(ImportReceipt.ImportReceiptFields.CreatedBy.ToString()));
				}

				businessObject.Id = dataReader.GetInt32(GetIndex(ImportReceipt.ImportReceiptFields.Id.ToString()));

			if (GetIndex(ImportReceipt.ImportReceiptFields.IdProvider.ToString()) != -1)
				businessObject.IdProvider = dataReader.GetInt32(GetIndex(ImportReceipt.ImportReceiptFields.IdProvider.ToString()));

			if (GetIndex(ImportReceipt.ImportReceiptFields.ImportDate.ToString()) != -1)
				businessObject.ImportDate = dataReader.GetDateTime(GetIndex(ImportReceipt.ImportReceiptFields.ImportDate.ToString()));

			if (GetIndex(ImportReceipt.ImportReceiptFields.IsDeleted.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ImportReceipt.ImportReceiptFields.IsDeleted.ToString())))
				{
					businessObject.IsDeleted = dataReader.GetInt32(GetIndex(ImportReceipt.ImportReceiptFields.IsDeleted.ToString()));
				}

			if (GetIndex(ImportReceipt.ImportReceiptFields.TotalPrice.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ImportReceipt.ImportReceiptFields.TotalPrice.ToString())))
				{
					businessObject.TotalPrice = dataReader.GetDecimal(GetIndex(ImportReceipt.ImportReceiptFields.TotalPrice.ToString()));
				}

			if (GetIndex(ImportReceipt.ImportReceiptFields.UpdatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ImportReceipt.ImportReceiptFields.UpdatedAt.ToString())))
				{
					businessObject.UpdatedAt = dataReader.GetDateTime(GetIndex(ImportReceipt.ImportReceiptFields.UpdatedAt.ToString()));
				}

			if (GetIndex(ImportReceipt.ImportReceiptFields.UpdatedBy.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ImportReceipt.ImportReceiptFields.UpdatedBy.ToString())))
				{
					businessObject.UpdatedBy = dataReader.GetInt32(GetIndex(ImportReceipt.ImportReceiptFields.UpdatedBy.ToString()));
				}


        }

        #endregion
	}
}
