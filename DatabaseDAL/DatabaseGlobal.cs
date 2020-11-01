using Anotar.NLog;
using Nexus.Common;
using Nexus.DatabaseDAL.Common;

namespace Nexus.DatabaseDAL
{
    public class DatabaseGlobal
    {
        public static void ReInit()
        {
                CommonGlobalConfig.IsUseMySql = false; //Mac dinh dung Sql Server

            LogTo.Info("CommonGlobalConfig.IsUseMySql = " + CommonGlobalConfig.IsUseMySql);
        }
        public static bool IsUseMySql()
        {
            return CommonGlobalConfig.IsUseMySql;
        }

        public static string GetDatabaseNameWorking(bool isHist, bool isReport)
        {
            return EntityManager.Instance.GetNameDataWorking();
        }
    }
}
