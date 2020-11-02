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
	public class ServicePackFeeSql : EntityBaseSql 
	{

        #region Constructor

		public ServicePackFeeSql()
		{
			 Init();
		}

        #endregion
		
		#region Init

		private void Init()
		{
           Insertsql = "ServicePackFee_Insert";
           Updatesql = "ServicePackFee_Update";
           Deletesql = "ServicePackFee_DeleteByPrimaryKey";
           Selectsql = "ServicePackFee_SelectAll";
		}

        #endregion

        #region Public override Methods

        public override SqlCommand GetSqlCommandForInsert(BaseEntity baseEntity)
		{
			var sqlCommand = new SqlCommand { CommandType = CommandTypeProcedure };
            if (baseEntity != null)
            {
                var businessObject = baseEntity as ServicePackFee;
                if (businessObject != null)
				{

								sqlCommand.Parameters.Add(new SqlParameter("@IdFee", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdFee));
				sqlCommand.Parameters.Add(new SqlParameter("@IdServicePack", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdServicePack));
				sqlCommand.Parameters.Add(new SqlParameter("@Value", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Value));


				}
			}
            return sqlCommand;	
		}

		public override BaseEntity UpdateEntityId(BaseEntity baseEntity, SqlCommand sqlCommand)
        {
            if (baseEntity != null)
            {
                return baseEntity;
                var businessObject = baseEntity as ServicePackFee;

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
                var businessObject = baseEntity as ServicePackFee;

                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@IdFee", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdFee));
				sqlCommand.Parameters.Add(new SqlParameter("@IdServicePack", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdServicePack));
				sqlCommand.Parameters.Add(new SqlParameter("@Value", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Value));

				
				}
			}       
         return sqlCommand;
		}
        
        public override SqlCommand GetSqlCommandForDelete(BaseEntity baseEntity)
		{
            var sqlCommand = new SqlCommand {CommandType = CommandTypeProcedure};
            if (baseEntity != null)
            {
                var businessObject = baseEntity as ServicePackFee;
                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@IdFee", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdFee));
				sqlCommand.Parameters.Add(new SqlParameter("@IdServicePack", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdServicePack));

				
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
                var businessObject = new ServicePackFee();
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

    internal void PopulateBusinessObjectFromReader(ServicePackFee businessObject, IDataReader dataReader)
        {
            if (_dicIndex.Count == 0) FillDicIndex(dataReader);
		
				businessObject.IdFee = dataReader.GetInt32(GetIndex(ServicePackFee.ServicePackFeeFields.IdFee.ToString()));

				businessObject.IdServicePack = dataReader.GetInt32(GetIndex(ServicePackFee.ServicePackFeeFields.IdServicePack.ToString()));

			if (GetIndex(ServicePackFee.ServicePackFeeFields.Value.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(ServicePackFee.ServicePackFeeFields.Value.ToString())))
				{
					businessObject.Value = dataReader.GetString(GetIndex(ServicePackFee.ServicePackFeeFields.Value.ToString()));
				}


        }

        #endregion
	}
}
