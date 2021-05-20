using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagementSystem.CRUD
{
    class SubjectClass
    {
        //getter and setter
        public string OfferdYear { get; set; }

        public int OfferdSemester { get; set; }

        public string SubjectName { get; set; }

        public string SubjectCode { get; set; }

        public int NoOfLectureHours { get; set; }

        public int NoOfTutorialHours { get; set; }

        public int NoOfLabHours { get; set; }

        public int NoOfEvaluationHours { get; set; }

        static string myconnstrng = Classes.ConnectionStrings.TimeTableSystem;

        //selecting data from database
        public DataTable Select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //writing sql query
                string sql = "Select * from Subject";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating Sql Data Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //inserting data into database

        public bool insertSubject(SubjectClass s)
        {
            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //creating a Sql query ti insert data
                string sql = "Insert into Subject(OfferdYear,OfferdSemester,SubjectName,SubjectCode,NoOfLectureHours,NoOfTutorilaHours,NoOfLabHours,NoOfEvaluationHours) VALUES(@OfferdYear,@OfferdSemester,@SubjectName,@SubjectCode,@NoOfLectureHours,@NoOfTutorialHours,@NoOfLabHours,@NoOfEvaluationHours)";

                //creatng a Sql command using sql and cmd

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@OfferdYear", s.OfferdYear);
                cmd.Parameters.AddWithValue("@OfferdSemester", s.OfferdSemester);
                cmd.Parameters.AddWithValue("@SubjectName", s.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", s.SubjectCode);
                cmd.Parameters.AddWithValue("@NoOfLectureHours", s.NoOfLectureHours);
                cmd.Parameters.AddWithValue("@NoOfTutorialHours", s.NoOfTutorialHours);
                cmd.Parameters.AddWithValue("@NoOfLabHours", s.NoOfLabHours);
                cmd.Parameters.AddWithValue("@NoOfEvaluationHours", s.NoOfEvaluationHours);

                // connection open here

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the queryrun successfully the the value of rows will be greater than zero slse if value will be 0

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }

        //method to update data in databse form our application

        public bool UpdateSubject(SubjectClass s)
        {
            //create a default return type and set its default values to false

            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "update Subject set OfferdYear = @OfferdYear, OfferdSemester = @OfferdSemester, SubjectName = @SubjectName, SubjectCode = @SubjectCode, NoOfLectureHours = @NoOfLectureHours, NoOfTutorilaHours = @NoOfTutorialHours,NoOfLabHours = @NoOfLabHours, NoOfEvaluationHours = @NoOfEvaluationHours where SubjectCode = @SubjectCode";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //create paramters to add values

                cmd.Parameters.AddWithValue("@OfferdYear", s.OfferdYear);
                cmd.Parameters.AddWithValue("@OfferdSemester", s.OfferdSemester);
                cmd.Parameters.AddWithValue("@SubjectName", s.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", s.SubjectCode);
                cmd.Parameters.AddWithValue("@NoOfLectureHours", s.NoOfLectureHours);
                cmd.Parameters.AddWithValue("@NoOfTutorialHours", s.NoOfTutorialHours);
                cmd.Parameters.AddWithValue("@NoOfLabHours", s.NoOfLabHours);
                cmd.Parameters.AddWithValue("@NoOfEvaluationHours", s.NoOfEvaluationHours);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if the query run successfully the the value of rows will be greater than zero slse if value will be 0

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        public bool DeleteSubject(SubjectClass s)
        {
            //create a default value and set its value to false
            bool isSuccess = false;

            //creating Sql connection

            SqlConnection conn = new SqlConnection(myconnstrng);


            try
            {
                //sql to delete Data
                string sql = "Delete from Subject where SubjectCode = @SubjectCode";


                //creating sql command

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SubjectCode", s.SubjectCode);

                //open connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                ////if the query run successfully the the value of rows will be greater than zero slse if value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //close the connection
                conn.Close();
            }
            return isSuccess;
        }
    }
}
