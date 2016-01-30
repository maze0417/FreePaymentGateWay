using FreePayment.Data.Models.Enums;

namespace FreePayment.Data.Models.DTOs
{
    public interface IApiResponse
    {
        ApiResponseCode ResponseCode { get; set; }
        string ResponseMessage { get; set; }
    }

    public class ApiResponse : IApiResponse
    {
        public ApiResponse()
        {
            ResponseCode = ApiResponseCode.SystemError;
        }

        public ApiResponseCode ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
    }
}