using System.Web.Http;

namespace EME.WebApi.Controllers.Api
{
    
    public class DefaultController : ApiController
    {
        //[Route, HttpGet]
        //public async Task<ApiStatusResponse> GetServerStatusAsync()
        //{
        //    var machineName = Environment.MachineName;
        //    var version = _serverStatusReport.GetWebEntryAssembly(HttpContext.Current).GetName().Version;
        //    var ugsUrls = _serverStatusReport.FindUgsUrls();

        //    var canConnectToDb = true;
        //    try
        //    {
        //        await _playerQueries.GetNumberPlayersAsync();
        //    }
        //    catch
        //    {
        //        canConnectToDb = false;
        //    }

        //    return new ApiStatusResponse
        //    {
        //        PhysicalPath = System.Web.Hosting.HostingEnvironment.MapPath("~/"),
        //        MachineName = machineName,
        //        Version = version.ToString(),
        //        DbVersion = BaseMigrationsConfiguration.DbVersion.ToString(),
        //        UgsUrls = ugsUrls,
        //        CanConnectToDb = canConnectToDb
        //    };
        //}
    }
}
