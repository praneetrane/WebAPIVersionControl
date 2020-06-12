using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIVersioning.Models;

namespace WebAPIVersioning.Controllers
{
    public class EmployeeV2Controller : ApiController
    {
        List<EmployeeV2> lstEmployeeV2 = new List<EmployeeV2>() { 
        
            new EmployeeV2() { ID=1,FirstName="Akash",LastName="Juneja",DOB=new DateTime(1988,09,08), City="Gurugram" ,State="HR", Country="India"},
             new EmployeeV2() { ID=1,FirstName="Ajit",LastName="Shinde",DOB=new DateTime(1986,05,28), City="Navi Mumbai" ,State="MH", Country="India"},
              new EmployeeV2() { ID=1,FirstName="Satish",LastName="Awasthi",DOB=new DateTime(1999,02,07), City="New Delhi" ,State="DL", Country="India"},
               new EmployeeV2() { ID=1,FirstName="Swaminathan",LastName="Nair",DOB=new DateTime(1981,07,24), City="Kochi" ,State="KL", Country="India"}
        };
        //Versioning using Attribute Routing
         [Route("api/v2/Employee")]
        public IHttpActionResult Get()
        {
            return Ok(lstEmployeeV2);
        }
    }
}
