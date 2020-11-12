using System;
using System.Linq;
using Nexus.Common.Enum;
using Nexus.Entity.Entities;

namespace Nexus.Utils
{
    public class Operator
    {
        public static readonly string SPECIAL_CHARS = "~@#$%^()_[]{}";

        public static bool IsAdmin(Employee employee)
        {
            try
            {
                if (employee != null && employee.Role == RoleDefinitionEnum.admin.ToString())
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Logger.Write(ex.ToString(), true);
                return false;
            }
        }
        
    }

    
}
