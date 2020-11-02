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
	public class ContractSql : EntityBaseSql 
	{

        #region Constructor

		public ContractSql()
		{
			 Init();
		}

        #endregion
		
		#region Init

		private void Init()
		{
           Insertsql = "Contract_Insert";
           Updatesql = "Contract_Update";
           Deletesql = "Contract_DeleteByPrimaryKey";
           Selectsql = "Contract_SelectAll";
		}

        #endregion

        #region Public override Methods

        public override SqlCommand GetSqlCommandForInsert(BaseEntity baseEntity)
		{
			var sqlCommand = new SqlCommand { CommandType = CommandTypeProcedure };
            if (baseEntity != null)
            {
                var businessObject = baseEntity as Contract;
                if (businessObject != null)
				{

								sqlCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Address));
				sqlCommand.Parameters.Add(new SqlParameter("@ContractId", SqlDbType.VarChar, 45, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ContractId));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.Text, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedDate));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdArea", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdArea));
				sqlCommand.Parameters.Add(new SqlParameter("@IdCustomer", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdCustomer));
				sqlCommand.Parameters.Add(new SqlParameter("@NextPayment", SqlDbType.Text, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NextPayment));


				}
			}
            return sqlCommand;	
		}

		public override BaseEntity UpdateEntityId(BaseEntity baseEntity, SqlCommand sqlCommand)
        {
            if (baseEntity != null)
            {
                return baseEntity;
                var businessObject = baseEntity as Contract;

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
                var businessObject = baseEntity as Contract;

                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Address));
				sqlCommand.Parameters.Add(new SqlParameter("@ContractId", SqlDbType.VarChar, 45, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ContractId));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.Text, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedDate));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdArea", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdArea));
				sqlCommand.Parameters.Add(new SqlParameter("@IdCustomer", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdCustomer));
				sqlCommand.Parameters.Add(new SqlParameter("@NextPayment", SqlDbType.Text, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.NextPayment));

				
				}
			}       
         return sqlCommand;
		}
        
        public override SqlCommand GetSqlCommandForDelete(BaseEntity baseEntity)
		{
            var sqlCommand = new SqlCommand {CommandType = CommandTypeProcedure};
            if (baseEntity != null)
            {
                var businessObject = baseEntity as Contract;
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
                var businessObject = new Contract();
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

    internal void PopulateBusinessObjectFromReader(Contract businessObject, IDataReader dataReader)
        {
            if (_dicIndex.Count == 0) FillDicIndex(dataReader);
		
			if (GetIndex(Contract.ContractFields.Address.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Contract.ContractFields.Address.ToString())))
				{
					businessObject.Address = dataReader.GetString(GetIndex(Contract.ContractFields.Address.ToString()));
				}

			if (GetIndex(Contract.ContractFields.ContractId.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Contract.ContractFields.ContractId.ToString())))
				{
					businessObject.ContractId = dataReader.GetString(GetIndex(Contract.ContractFields.ContractId.ToString()));
				}

			if (GetIndex(Contract.ContractFields.CreatedDate.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Contract.ContractFields.CreatedDate.ToString())))
				{
					businessObject.CreatedDate = dataReader.GetDateTime(GetIndex(Contract.ContractFields.CreatedDate.ToString()));
				}

				businessObject.Id = dataReader.GetInt32(GetIndex(Contract.ContractFields.Id.ToString()));

			if (GetIndex(Contract.ContractFields.IdArea.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Contract.ContractFields.IdArea.ToString())))
				{
					businessObject.IdArea = dataReader.GetInt32(GetIndex(Contract.ContractFields.IdArea.ToString()));
				}

			if (GetIndex(Contract.ContractFields.IdCustomer.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Contract.ContractFields.IdCustomer.ToString())))
				{
					businessObject.IdCustomer = dataReader.GetInt32(GetIndex(Contract.ContractFields.IdCustomer.ToString()));
				}

			if (GetIndex(Contract.ContractFields.NextPayment.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Contract.ContractFields.NextPayment.ToString())))
				{
					businessObject.NextPayment = dataReader.GetDateTime(GetIndex(Contract.ContractFields.NextPayment.ToString()));
				}


        }

        #endregion
	}
}
