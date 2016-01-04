namespace FP.Core.Interfaces.Context
{
    public interface IDataConfig
    {
        string KeyForConnectionString { get; }
        string KeyForHangfireConnectionString { get; }
    }
}