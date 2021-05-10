using ATI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ATI.Repository
{
    public class StudentRepository
    {
        /**GET ALL STUDENT DETAILS*/
        public List<StudentModel> GetAllStudents()
        {
            /***List is used for to display List of Students**/
            List<StudentModel> theStudents = new List<StudentModel>();
            /*Object Creation For Student Model*/
            StudentModel studentModel = null;
            /**
              con=For Creating Connection
               database=ATI ==>DateBase Name
             */
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                /*       SqlConnection
                       con = new SqlConnection("data source=.; database=ATI;integrated security=SSPI");*/

                /** con = new SqlConnection(connectionString); **/
                con.Open();
            /**FOR FETCHING ALL RECORDS OF ATI_STUDENT DETAILS*/
            string query = "select * from ATI_STUDENT";
            /* FOR EXECUTING THE QUERY*/
            SqlCommand cm = new SqlCommand(query, con);
            /** FOR READING THE DATABASE RECORDS*/
            SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    studentModel = new StudentModel();
                    /*FOR CONVERTING STUDENT ID TO INTEGER*/
                    studentModel.STUDENT_ID = Convert.ToInt32(sdr["STUDENT_ID"]);
                    /*FOR CONVERTING USERNAME  TO  STRING*/
                    studentModel.USERNAME = Convert.ToString(sdr["USERNAME"]);
                    /*Cntrl+E or Cntrl+d Formatting*/
                    studentModel.EMAIL = Convert.ToString(sdr["EMAIL"]);
                    studentModel.PASSWORD = Convert.ToString(sdr["PASSWORD"]);
                    studentModel.MOBILE_NUMBER = Convert.ToInt64(sdr["MOBILE_NUMBER"]);
                    studentModel.ADDRESS = Convert.ToString(sdr["ADDRESS"]);
                    studentModel.DOB = Convert.ToDateTime(sdr["DOB"]);
                    studentModel.GENDER = Convert.ToString(sdr["GENDER"]);
                    studentModel.CREATED_DATE = Convert.ToDateTime(sdr["CREATED_DATE"]);
                    studentModel.UPDATED_DATE = Convert.ToDateTime(sdr["UPDATED_DATE"]);
                    /**Adding Object to the List*/
                    theStudents.Add(studentModel);
                 
                   
                }

                con.Close();
            }
            catch (Exception e) 
            {
                /**Raising the Exception*/
                Console.WriteLine(e);
            }
            return theStudents;
        }
      
    }
}