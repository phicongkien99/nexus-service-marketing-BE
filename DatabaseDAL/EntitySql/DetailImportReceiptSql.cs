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
	public class DetailImportReceiptSql : EntityBaseSql 
	{

        #region Constructor

		public DetailImportReceiptSql()
		{
			 Init();
		}

        #endregion
		
		#region Init

		private void Init()
		{
           Insertsql = "DetailImportReceipt_Insert";
           Updatesql = "DetailImportReceipt_Update";
           Deletesql = "DetailImportReceipt_DeleteByPrimaryKey";
           Selectsql = "DetailImportReceipt_SelectAll";
		}

        #endregion

        #region Public override Methods

        public override SqlCommand GetSqlCommandForInsert(BaseEntity baseEntity)
		{
			var sqlCommand = new SqlCommand { CommandType = CommandTypeProcedure };
            if (baseEntity != null)
            {
                var businessObject = baseEntity as DetailImportReceipt;
                if (businessObject != null)
				{

								sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@IdDevice", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdDevice));
				sqlCommand.Parameters.Add(new SqlParameter("@IdImportReceipt", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdImportReceipt));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDeleted", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDeleted));
				sqlCommand.Parameters.Add(new SqlParameter("@Price", SqlDbType.Decimal, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Price));
				sqlCommand.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Quantity));
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
                var businessObject = baseEntity as DetailImportReceipt;

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
                var businessObject = baseEntity as DetailImportReceipt;

                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@IdDevice", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdDevice));
				sqlCommand.Parameters.Add(new SqlParameter("@IdImportReceipt", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdImportReceipt));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDeleted", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDeleted));
				sqlCommand.Parameters.Add(new SqlParameter("@Price", SqlDbType.Decimal, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Price));
				sqlCommand.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Quantity));
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
                var businessObject = baseEntity as DetailImportReceipt;
                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@IdDevice", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdDevice));
				sqlCommand.Parameters.Add(new SqlParameter("@IdImportReceipt", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdImportReceipt));

				
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
                var businessObject = new DetailImportReceipt();
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

    internal void PopulateBusinessObjectFromReader(DetailImportReceipt businessObject, IDataReader dataReader)
        {
            if (_dicIndex.Count == 0) FillDicIndex(dataReader);
		
			if (GetIndex(DetailImportReceipt.DetailImportReceiptFields.CreatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(DetailImportReceipt.DetailImportReceiptFields.CreatedAt.ToString())))
				{
					businessObject.CreatedAt = dataReader.GetDateTime(GetIndex(DetailImportReceipt.DetailImportReceiptFields.CreatedAt.ToString()));
				}

			if (GetIndex(DetailImportReceipt.DetailImportReceiptFields.CreatedBy.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(DetailImportReceipt.DetailImportReceiptFields.CreatedBy.ToString())))
				{
					businessObject.CreatedBy = dataReader.GetInt32(GetIndex(DetailImportReceipt.DetailImportReceiptFields.CreatedBy.ToString()));
				}

				businessObject.IdDevice = dataReader.GetInt32(GetIndex(DetailImportReceipt.DetailImportReceiptFields.IdDevice.ToString()));

				businessObject.IdImportReceipt = dataReader.GetInt32(GetIndex(DetailImportReceipt.DetailImportReceiptFields.IdImportReceipt.ToString()));

			if (GetIndex(DetailImportReceipt.DetailImportReceiptFields.IsDeleted.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(DetailImportReceipt.DetailImportReceiptFields.IsDeleted.ToString())))
				{
					businessObject.IsDeleted = dataReader.GetInt32(GetIndex(DetailImportReceipt.DetailImportReceiptFields.IsDeleted.ToString()));
				}

			if (GetIndex(DetailImportReceipt.DetailImportReceiptFields.Price.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(DetailImportReceipt.DetailImportReceiptFields.Price.ToString())))
				{
					businessObject.Price = dataReader.GetDecimal(GetIndex(DetailImportReceipt.DetailImportReceiptFields.Price.ToString()));
				}

			if (GetIndex(DetailImportReceipt.DetailImportReceiptFields.Quantity.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(DetailImportReceipt.DetailImportReceiptFields.Quantity.ToString())))
				{
					businessObject.Quantity = dataReader.GetInt32(GetIndex(DetailImportReceipt.DetailImportReceiptFields.Quantity.ToString()));
				}

			if (GetIndex(DetailImportReceipt.DetailImportReceiptFields.UpdatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(DetailImportReceipt.DetailImportReceiptFields.UpdatedAt.ToString())))
				{
					businessObject.UpdatedAt = dataReader.GetDateTime(GetIndex(DetailImportReceipt.DetailImportReceiptFields.UpdatedAt.ToString()));
				}

			if (GetIndex(DetailImportReceipt.DetailImportReceiptFields.UpdatedBy.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(DetailImportReceipt.DetailImportReceiptFields.UpdatedBy.ToString())))
				{
					businessObject.UpdatedBy = dataReader.GetInt32(GetIndex(DetailImportReceipt.DetailImportReceiptFields.UpdatedBy.ToString()));
				}


        }

        #endregion
	}
}
