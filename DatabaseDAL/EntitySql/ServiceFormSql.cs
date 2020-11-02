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

								sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdCustomer", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdCustomer));
				sqlCommand.Parameters.Add(new SqlParameter("@IdEmployee", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdEmployee));
				sqlCommand.Parameters.Add(new SqlParameter("@IdServiceFormStatus", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdServiceFormStatus));
				sqlCommand.Parameters.Add(new SqlParameter("@IdServicePack", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdServicePack));


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

								sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdCustomer", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdCustomer));
				sqlCommand.Parameters.Add(new SqlParameter("@IdEmployee", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdEmployee));
				sqlCommand.Parameters.Add(new SqlParameter("@IdServiceFormStatus", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdServiceFormStatus));
				sqlCommand.Parameters.Add(new SqlParameter("@IdServicePack", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdServicePack));

				
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
		
				businessObject.Id = dataReader.GetInt32(GetIndex(ServiceForm.ServiceFormFields.Id.ToString()));

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
				if (!dataReader.IsDBNull(GetIndex(ServiceForm.ServiceFormFields.IdServicePack.ToString())))
				{
					businessObject.IdServicePack = dataReader.GetInt32(GetIndex(ServiceForm.ServiceFormFields.IdServicePack.ToString()));
				}


        }

        #endregion
	}
}
