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
	public class EmployeeSql : EntityBaseSql 
	{

        #region Constructor

		public EmployeeSql()
		{
			 Init();
		}

        #endregion
		
		#region Init

		private void Init()
		{
           Insertsql = "Employee_Insert";
           Updatesql = "Employee_Update";
           Deletesql = "Employee_DeleteByPrimaryKey";
           Selectsql = "Employee_SelectAll";
		}

        #endregion

        #region Public override Methods

        public override SqlCommand GetSqlCommandForInsert(BaseEntity baseEntity)
		{
			var sqlCommand = new SqlCommand { CommandType = CommandTypeProcedure };
            if (baseEntity != null)
            {
                var businessObject = baseEntity as Employee;
                if (businessObject != null)
				{

								sqlCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Address));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Email));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdStore", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdStore));
				sqlCommand.Parameters.Add(new SqlParameter("@IsActivated", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsActivated));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDeleted", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDeleted));
				sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
				sqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Password));
				sqlCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Phone));
				sqlCommand.Parameters.Add(new SqlParameter("@Role", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Role));
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
                var businessObject = baseEntity as Employee;

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
                var businessObject = baseEntity as Employee;

                if (businessObject != null)
                {

								sqlCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Address));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedAt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedAt));
				sqlCommand.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.CreatedBy));
				sqlCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Email));
				sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Id));
				sqlCommand.Parameters.Add(new SqlParameter("@IdStore", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IdStore));
				sqlCommand.Parameters.Add(new SqlParameter("@IsActivated", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsActivated));
				sqlCommand.Parameters.Add(new SqlParameter("@IsDeleted", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.IsDeleted));
				sqlCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Name));
				sqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Password));
				sqlCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Phone));
				sqlCommand.Parameters.Add(new SqlParameter("@Role", SqlDbType.VarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, businessObject.Role));
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
                var businessObject = baseEntity as Employee;
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
                var businessObject = new Employee();
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

    internal void PopulateBusinessObjectFromReader(Employee businessObject, IDataReader dataReader)
        {
            if (_dicIndex.Count == 0) FillDicIndex(dataReader);
		
			if (GetIndex(Employee.EmployeeFields.Address.ToString()) != -1)
				businessObject.Address = dataReader.GetString(GetIndex(Employee.EmployeeFields.Address.ToString()));

			if (GetIndex(Employee.EmployeeFields.CreatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Employee.EmployeeFields.CreatedAt.ToString())))
				{
					businessObject.CreatedAt = dataReader.GetDateTime(GetIndex(Employee.EmployeeFields.CreatedAt.ToString()));
				}

			if (GetIndex(Employee.EmployeeFields.CreatedBy.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Employee.EmployeeFields.CreatedBy.ToString())))
				{
					businessObject.CreatedBy = dataReader.GetInt32(GetIndex(Employee.EmployeeFields.CreatedBy.ToString()));
				}

			if (GetIndex(Employee.EmployeeFields.Email.ToString()) != -1)
				businessObject.Email = dataReader.GetString(GetIndex(Employee.EmployeeFields.Email.ToString()));

				businessObject.Id = dataReader.GetInt32(GetIndex(Employee.EmployeeFields.Id.ToString()));

			if (GetIndex(Employee.EmployeeFields.IdStore.ToString()) != -1)
				businessObject.IdStore = dataReader.GetInt32(GetIndex(Employee.EmployeeFields.IdStore.ToString()));

			if (GetIndex(Employee.EmployeeFields.IsActivated.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Employee.EmployeeFields.IsActivated.ToString())))
				{
					businessObject.IsActivated = dataReader.GetInt32(GetIndex(Employee.EmployeeFields.IsActivated.ToString()));
				}

			if (GetIndex(Employee.EmployeeFields.IsDeleted.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Employee.EmployeeFields.IsDeleted.ToString())))
				{
					businessObject.IsDeleted = dataReader.GetInt32(GetIndex(Employee.EmployeeFields.IsDeleted.ToString()));
				}

			if (GetIndex(Employee.EmployeeFields.Name.ToString()) != -1)
				businessObject.Name = dataReader.GetString(GetIndex(Employee.EmployeeFields.Name.ToString()));

			if (GetIndex(Employee.EmployeeFields.Password.ToString()) != -1)
				businessObject.Password = dataReader.GetString(GetIndex(Employee.EmployeeFields.Password.ToString()));

			if (GetIndex(Employee.EmployeeFields.Phone.ToString()) != -1)
				businessObject.Phone = dataReader.GetString(GetIndex(Employee.EmployeeFields.Phone.ToString()));

			if (GetIndex(Employee.EmployeeFields.Role.ToString()) != -1)
				businessObject.Role = dataReader.GetString(GetIndex(Employee.EmployeeFields.Role.ToString()));

			if (GetIndex(Employee.EmployeeFields.UpdatedAt.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Employee.EmployeeFields.UpdatedAt.ToString())))
				{
					businessObject.UpdatedAt = dataReader.GetDateTime(GetIndex(Employee.EmployeeFields.UpdatedAt.ToString()));
				}

			if (GetIndex(Employee.EmployeeFields.UpdatedBy.ToString()) != -1)
				if (!dataReader.IsDBNull(GetIndex(Employee.EmployeeFields.UpdatedBy.ToString())))
				{
					businessObject.UpdatedBy = dataReader.GetInt32(GetIndex(Employee.EmployeeFields.UpdatedBy.ToString()));
				}


        }

        #endregion
	}
}
