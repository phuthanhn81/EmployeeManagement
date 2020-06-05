using Model.DAO;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagement.API
{
    [RoutePrefix("api/chamcong")]
    public class CHAMCONGController : ApiController
    {
        [Route("all")]
        [HttpGet]
        public HttpResponseMessage All(string MABP, DateTime DATE)
        {
            var listbc = new ChamCongDAO().Load(MABP, DATE);
            int days = DateTime.DaysInMonth(DATE.Year, DATE.Month); // in số col cho đúng
            return Request.CreateResponse(HttpStatusCode.OK, new { listbc, days });
        }
    }
}
