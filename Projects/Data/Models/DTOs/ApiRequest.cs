namespace FreePayment.Data.Models.DTOs
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