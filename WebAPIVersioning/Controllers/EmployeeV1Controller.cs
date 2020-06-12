using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIVersioning.Models;

namespace WebAPIVersioning.Controllers
{
    public class EmployeeV1Controller : ApiController
    {
        List<EmployeeV1> lstEmployeeV1 = new List<EmployeeV1>() { 
        new EmployeeV1(){ID=1,Name="Akash",Age=32,City="Gurugram",State="HR"},
        new EmployeeV1(){ID=2,Name="Ajit",Age=34,City="Navi Mumbai",State="MH"},
        new EmployeeV1(){ID=3,Name="Satish",Age=21,City="New Delhi",State="DL"},
        new EmployeeV1(){ID=4,Name="Swaminathan",Age=39,City="Kochi",State="KL"}
        };

        //Versioning using Attribute Routing
        [Route("api/v1/Employee")]
        public IHttpActionResult Get()
        {
            return Ok(lstEmployeeV1);
        }

        public IHttpActionResult Get(int id)
        {
            return Ok(lstEmployeeV1.FirstOrDefault(e=>e.ID==id));
        }
    }
}
