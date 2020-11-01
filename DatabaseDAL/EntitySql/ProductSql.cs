using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Nexus.DatabaseDAL.Common;
using Nexus.Entity;
using Nexus.Entity.Entities;

namespace Nexus.DatabaseDAL.EntitySql
{
	public class ProductSql : EntityBaseSql 
	{

        #region Constructor

		public ProductSql()
		{
			 Init();
		}

        #endregion
		
		#region Init

		private void Init()
		{
           Insertsql = "Product_Insert";
           Updatesql = "Product_Update";
           Deletesql = "Product_DeleteByPrimaryKey";
           Selectsql = "Product_SelectAll";
		}

        #endregion

        #region Public override Methods

        public override SqlCommand GetSqlCommandForInsert(BaseEntity baseEntity)
		{
			var sqlCommand = new SqlCommand { CommandType = CommandTypeProcedure };
            if (baseEntity != null)
            {
                var businessObject = baseEntity as Product;
                if (businessObject != null)
				{

								sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdDisplay", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdDisplay));
				sqlCommand.Parameters.Add(new SqlParameter("@IdManufacturer", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdManufacturer));
				sqlCommand.Parameters.Add(new SqlParameter("@IdProductType", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdProductType));
				sqlCommand.Parameters.Add(new SqlParameter("@ImageId", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ImageId));
				sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
				sqlCommand.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Quantity));
				sqlCommand.Parameters.Add(new SqlParameter("@SupportDuration", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SupportDuration));
				sqlCommand.Parameters.Add(new SqlParameter("@UnitPrice", SqlDbType.Decimal, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UnitPrice));
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
                var businessObject = baseEntity as Product;

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
                var businessObject = baseEntity as Product;

                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Description));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdDisplay", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdDisplay));
				sqlCommand.Parameters.Add(new SqlParameter("@IdManufacturer", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdManufacturer));
				sqlCommand.Parameters.Add(new SqlParameter("@IdProductType", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdProductType));
				sqlCommand.Parameters.Add(new SqlParameter("@ImageId", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.ImageId));
				sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
				sqlCommand.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Quantity));
				sqlCommand.Parameters.Add(new SqlParameter("@SupportDuration", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.SupportDuration));
				sqlCommand.Parameters.Add(new SqlParameter("@UnitPrice", SqlDbType.Decimal, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.UnitPrice));
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
                var businessObject = baseEntity as Product;
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
                var businessObject = new Product();
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

    internal void PopulateBusinessObjectFromReader(Product businessObject, IDataReader dataReader)
        {
            if (_dicIndex.Count == 0) FillDicIndex(dataReader);
		
			if (GetIndex(Product.ProductFields.CreatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Product.ProductFields.CreatedAt.ToString())))
				{
					businessObject.CreatedAt = dataReader.GetDateTime(GetIndex(Product.ProductFields.CreatedAt.ToString()));
				}

			if (GetIndex(Product.ProductFields.CreatedBy.ToString()) != -1)
				businessObject.CreatedBy = dataReader.GetInt32(GetIndex(Product.ProductFields.CreatedBy.ToString()));

			if (GetIndex(Product.ProductFields.Description.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Product.ProductFields.Description.ToString())))
				{
					businessObject.Description = dataReader.GetString(GetIndex(Product.ProductFields.Description.ToString()));
				}

				businessObject.Id = dataReader.GetInt32(GetIndex(Product.ProductFields.Id.ToString()));

			if (GetIndex(Product.ProductFields.IdDisplay.ToString()) != -1)
				businessObject.IdDisplay = dataReader.GetString(GetIndex(Product.ProductFields.IdDisplay.ToString()));

			if (GetIndex(Product.ProductFields.IdManufacturer.ToString()) != -1)
				businessObject.IdManufacturer = dataReader.GetInt32(GetIndex(Product.ProductFields.IdManufacturer.ToString()));

			if (GetIndex(Product.ProductFields.IdProductType.ToString()) != -1)
				businessObject.IdProductType = dataReader.GetInt32(GetIndex(Product.ProductFields.IdProductType.ToString()));

			if (GetIndex(Product.ProductFields.ImageId.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Product.ProductFields.ImageId.ToString())))
				{
					businessObject.ImageId = dataReader.GetString(GetIndex(Product.ProductFields.ImageId.ToString()));
				}

			if (GetIndex(Product.ProductFields.Name.ToString()) != -1)
				businessObject.Name = dataReader.GetString(GetIndex(Product.ProductFields.Name.ToString()));

			if (GetIndex(Product.ProductFields.Quantity.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Product.ProductFields.Quantity.ToString())))
				{
					businessObject.Quantity = dataReader.GetInt32(GetIndex(Product.ProductFields.Quantity.ToString()));
				}

			if (GetIndex(Product.ProductFields.SupportDuration.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Product.ProductFields.SupportDuration.ToString())))
				{
					businessObject.SupportDuration = dataReader.GetInt32(GetIndex(Product.ProductFields.SupportDuration.ToString()));
				}

			if (GetIndex(Product.ProductFields.UnitPrice.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Product.ProductFields.UnitPrice.ToString())))
				{
					businessObject.UnitPrice = dataReader.GetDecimal(GetIndex(Product.ProductFields.UnitPrice.ToString()));
				}

			if (GetIndex(Product.ProductFields.UpdatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Product.ProductFields.UpdatedAt.ToString())))
				{
					businessObject.UpdatedAt = dataReader.GetDateTime(GetIndex(Product.ProductFields.UpdatedAt.ToString()));
				}

			if (GetIndex(Product.ProductFields.UpdatedBy.ToString()) != -1)
				businessObject.UpdatedBy = dataReader.GetInt32(GetIndex(Product.ProductFields.UpdatedBy.ToString()));


        }

        #endregion
	}
}
