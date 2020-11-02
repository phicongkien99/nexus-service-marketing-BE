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
	public class PaymentSql : EntityBaseSql 
	{

        #region Constructor

		public PaymentSql()
		{
			 Init();
		}

        #endregion
		
		#region Init

		private void Init()
		{
           Insertsql = "Payment_Insert";
           Updatesql = "Payment_Update";
           Deletesql = "Payment_DeleteByPrimaryKey";
           Selectsql = "Payment_SelectAll";
		}

        #endregion

        #region Public override Methods

        public override SqlCommand GetSqlCommandForInsert(BaseEntity baseEntity)
		{
			var sqlCommand = new SqlCommand { CommandType = CommandTypeProcedure };
            if (baseEntity != null)
            {
                var businessObject = baseEntity as Payment;
                if (businessObject != null)
				{

								sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdContract", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdContract));
				sqlCommand.Parameters.Add(new SqlParameter("@PayDate", SqlDbType.Text, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PayDate));
				sqlCommand.Parameters.Add(new SqlParameter("@TotalPrice", SqlDbType.Decimal, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TotalPrice));


				}
			}
            return sqlCommand;	
		}

		public override BaseEntity UpdateEntityId(BaseEntity baseEntity, SqlCommand sqlCommand)
        {
            if (baseEntity != null)
            {
                return baseEntity;
                var businessObject = baseEntity as Payment;

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
                var businessObject = baseEntity as Payment;

                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdContract", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdContract));
				sqlCommand.Parameters.Add(new SqlParameter("@PayDate", SqlDbType.Text, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.PayDate));
				sqlCommand.Parameters.Add(new SqlParameter("@TotalPrice", SqlDbType.Decimal, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.TotalPrice));

				
				}
			}       
         return sqlCommand;
		}
        
        public override SqlCommand GetSqlCommandForDelete(BaseEntity baseEntity)
		{
            var sqlCommand = new SqlCommand {CommandType = CommandTypeProcedure};
            if (baseEntity != null)
            {
                var businessObject = baseEntity as Payment;
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
                var businessObject = new Payment();
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

    internal void PopulateBusinessObjectFromReader(Payment businessObject, IDataReader dataReader)
        {
            if (_dicIndex.Count == 0) FillDicIndex(dataReader);
		
				businessObject.Id = dataReader.GetInt32(GetIndex(Payment.PaymentFields.Id.ToString()));

			if (GetIndex(Payment.PaymentFields.IdContract.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Payment.PaymentFields.IdContract.ToString())))
				{
					businessObject.IdContract = dataReader.GetInt32(GetIndex(Payment.PaymentFields.IdContract.ToString()));
				}

			if (GetIndex(Payment.PaymentFields.PayDate.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Payment.PaymentFields.PayDate.ToString())))
				{
					businessObject.PayDate = dataReader.GetDateTime(GetIndex(Payment.PaymentFields.PayDate.ToString()));
				}

			if (GetIndex(Payment.PaymentFields.TotalPrice.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Payment.PaymentFields.TotalPrice.ToString())))
				{
					businessObject.TotalPrice = dataReader.GetDecimal(GetIndex(Payment.PaymentFields.TotalPrice.ToString()));
				}


        }

        #endregion
	}
}
