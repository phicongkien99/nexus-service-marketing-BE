namespace Nexus.Common.Config
{
    public class NexusConfig : IConfig
    {
        public string Secret { get; set; }
        public int Port { get; set; }
        public bool SendConfirmEmail { get; set; }
        public string FolderSaveImages { get; set; }
        public string BaseUrl { get; set; }
        public bool IsSendLogToBot { get; set; }
        public string MailGunToken { get; set; }

        public void Dispose()
        {
            Secret = null;
        }

        public static string FileName()
        {
            return typeof(NexusConfig).Name;
        }

        public string GetFileName()
        {
            return FileName();
        }

    }
}
