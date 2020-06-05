using Model.DAO;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagement.API
{
    [RoutePrefix("api/bophan")]
    public class BOPHANController : ApiController
    {
        [Route("all")]
        [HttpGet]
        public HttpResponseMessage All()
        {
            var listbp = new BoPhanDAO().All();
            return Request.CreateResponse(HttpStatusCode.OK, new { listbp });
        }
    }
}
