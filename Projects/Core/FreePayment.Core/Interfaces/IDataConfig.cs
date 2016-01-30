namespace FreePayment.Core.Interfaces
{
    public interface IDataConfig
    {
        string KeyForConnectionString { get; }
        string KeyForHangfireConnectionString { get; }
        string TablePrefix { get; }
        string TableSchema { get; }
    }
}