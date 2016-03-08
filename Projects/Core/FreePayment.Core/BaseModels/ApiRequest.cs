namespace EME.Infrastructure.Common.BaseModels
{
    public interface IApiRequest
    {
        string AuthToken { get; set; }
    }

    public class ApiRequest : IApiRequest
    {
        public string AuthToken { get; set; }
    }
}