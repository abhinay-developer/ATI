using ATI.BusinessLayer;
using ATI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ATI.Controllers
{
   
    public class StudentController : ApiController
    {
        /**GET METHOD*/
        [HttpGet]
        /**API URL*/
         [Route("api/GetAllStudents")]
         public List<StudentModel> GetAllStudentsCon(){
            StudentBusiness studentBusiness = new StudentBusiness();
            return studentBusiness.GetAllStudentsBus();

             

        }

    }
}
