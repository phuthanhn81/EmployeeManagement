using Model.DAO;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagement.API
{
    [RoutePrefix("api/chucvu")]
    public class CHUCVUController : ApiController
    {
        [Route("all")]
        [HttpGet]
        public HttpResponseMessage All()
        {
            var listcv = new ChucVuDAO().All();
            return Request.CreateResponse(HttpStatusCode.OK, new { listcv });
        }
    }
}
