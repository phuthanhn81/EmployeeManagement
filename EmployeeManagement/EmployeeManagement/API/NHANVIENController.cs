using Model.DAO;
using Model.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace EmployeeManagement.API
{
    [RoutePrefix("api/nhanvien")]
    public class NHANVIENController : ApiController
    {
        [Route("all")]
        [HttpGet]
        public HttpResponseMessage All()
        {
            var listnv = new NhanVienDAO().All();
            return Request.CreateResponse(HttpStatusCode.OK, new { listnv });
        }

        [Route("delete")]
        [HttpDelete]
        public HttpResponseMessage Delete([FromBody]NHANVIEN nv)
        {
            bool result = new NhanVienDAO().Delete(nv);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { nv });
            }
            else
            {
                string json = new JavaScriptSerializer().Serialize(nv);
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, json);
            }
        }

        [Route("create")]
        [HttpPost]
        public HttpResponseMessage Create([FromBody]NHANVIEN nv)
        {
            NHANVIEN result = new NhanVienDAO().Create(nv);
            if (result != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { result });
            }
            else
            {
                string json = new JavaScriptSerializer().Serialize(nv);
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, json);
            }
        }

        [Route("update")]
        [HttpPut]
        public HttpResponseMessage Update([FromBody]NHANVIEN nv)
        {
            NHANVIEN result = new NhanVienDAO().Update(nv);
            if (result != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { result });
            }
            else
            {
                string json = new JavaScriptSerializer().Serialize(nv);
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, json);
            }
        }
    }
}
