using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using FreePayment.Data.Models.DTOs;
using FreePayment.Data.Models.Enums;

namespace FreePayment.Core.Infrastructure.Filters.Api
{
    public class HandleExceptionAttribute : ExceptionFilterAttribute
    {
        public override Task OnExceptionAsync(HttpActionExecutedContext actionExecutedContext,
          CancellationToken cancellationToken)
        {
            if (actionExecutedContext.Exception == null)
                return base.OnExceptionAsync(actionExecutedContext, cancellationToken);

            actionExecutedContext.Response =
                actionExecutedContext.Request.CreateResponse(HttpStatusCode.InternalServerError,
                    new ApiResponse { ResponseCode = ApiResponseCode.SystemError, ResponseMessage = actionExecutedContext.Exception.Message });

            return base.OnExceptionAsync(actionExecutedContext, cancellationToken);
        }
    }
}