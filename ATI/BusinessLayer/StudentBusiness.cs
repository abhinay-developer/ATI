using ATI.Models;
using ATI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATI.BusinessLayer
{
    public class StudentBusiness
    {
        /*ALT +ENTER FOR IMPORTS */
        public List<StudentModel> GetAllStudentsBus()
        {
            /*Creating Student Repository Object*/
            StudentRepository studentRepo = new StudentRepository();
             /**fetching the StudentRepo Details**/
            return studentRepo.GetAllStudents();
        }
    }
}