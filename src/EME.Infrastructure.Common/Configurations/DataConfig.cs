using EME.Infrastructure.Common.Helpers;

namespace EME.Infrastructure.Common.Configurations
{
    public interface IDataConfig
    {
        string KeyForConnectionString { get; }
        string KeyForHangfireConnectionString { get; }
        string TablePrefix { get; }
        string TableSchema { get; }
    }
    public class DataConfig : IDataConfig
    {
        private const string Prefix = "data-api-";

        string IDataConfig.KeyForConnectionString
        {
            get { return AppConfigHelper.AppSetting(Prefix + "key-for-connection-string", "Default"); }
        }

        string IDataConfig.KeyForHangfireConnectionString
        {
            get { return AppConfigHelper.AppSetting(Prefix + "key-for-hangfire-connection-string", "Hangfire"); }
        }

        string IDataConfig.TablePrefix
        {
            get { return AppConfigHelper.AppSetting(Prefix + "table-prefix", ""); }
        }

        string IDataConfig.TableSchema
        {
            get { return AppConfigHelper.AppSetting(Prefix + "table-schema", (string)null); }
        }
    }
}