using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TimeManagementSystem.CRUD
{
    class LectureClass
    {
        //Getter and Setter
        
        public int EmployeeID { get; set; }

        public string LectureName { get; set; }

        public string Faculty { get; set; }

        public string Department { get; set; }

        public string Center { get; set; }

        public string Building { get; set; }

        public int Level { get; set; }

        public string Rank { get; set; }

        public string SelectDay { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }


        static string myconnstrng = Classes.ConnectionStrings.TBMS;

        //selecting data from database

        public DataTable Select()
        {
            //database connection
            SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();

            DataTable dt = new DataTable();

            try
            {
                //writing Sql query
                string sql = "Select * from Lecturer";

                //creating cmd using sql and conn
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                //creating Sql Data Adapter using cmd
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //insertign Data into database
        public bool InsertLecturer(LectureClass L)
        {
            string myconnstrng = Classes.ConnectionStrings.TBMS;

            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //connect database
                        SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();

            try
            {
                //create a sql query to insert data
                string sql = "Insert into Lecturer(EmployeeID,LectureName,Faculty,Department,Center,Building,Level,Rank,SelectDay,StartTime,EndTime) VALUES(@EmployeeID,@LectureName,@Faculty,@Department,@Center,@Building,@Level,@Rank,@SelectDay,@StartTime,@EndTime)";

                //creating Sql command using sql and cmd

                SQLiteCommand cmd = new SQLiteCommand(sql,conn);

                cmd.Parameters.AddWithValue("@EmployeeID", L.EmployeeID);
                cmd.Parameters.AddWithValue("@LectureName", L.LectureName);
                cmd.Parameters.AddWithValue("@Faculty", L.Faculty);
                cmd.Parameters.AddWithValue("@Department", L.Department);
                cmd.Parameters.AddWithValue("@Center", L.Center);
                cmd.Parameters.AddWithValue("@Building", L.Building);
                cmd.Parameters.AddWithValue("@Level", L.Level);
                cmd.Parameters.AddWithValue("@Rank", L.Rank);
                cmd.Parameters.AddWithValue("@SelectDay", L.SelectDay);
                cmd.Parameters.AddWithValue("@StartTime", L.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", L.EndTime);

                //connection open here

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the queryrun successfully the the value of rows will be greater than zero slse if value will be 0

                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }

        //Method to update data in database from our application

        public bool UpdateLecturer(LectureClass L)
        {
            //create a default return type and set its default values to false

            bool isSuccess = false;
                        SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();

            try
            {
                //sql to update data in our database

                string sql = "Update Lecturer SET EmployeeID = @EmployeeID, LectureName = @LectureName, Faculty = @Faculty, Department =@Department, Center = @Center, Building = @Building, Level = @Level, Rank = @Rank, SelectDay = @SelectDay, StartTime = @StartTime, EndTime = @EndTime where EmployeeID = @EmployeeID";

                //creating sql command
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                //create parametrs to add value

              
                cmd.Parameters.AddWithValue("@EmployeeID", L.EmployeeID);
                cmd.Parameters.AddWithValue("@LectureName", L.LectureName);
                cmd.Parameters.AddWithValue("@Faculty", L.Faculty);
                cmd.Parameters.AddWithValue("@Department", L.Department);
                cmd.Parameters.AddWithValue("@Center", L.Center);
                cmd.Parameters.AddWithValue("@Building", L.Building);
                cmd.Parameters.AddWithValue("@Level", L.Level);
                cmd.Parameters.AddWithValue("@Rank", L.Rank);
                cmd.Parameters.AddWithValue("@SelectDay", L.SelectDay);
                cmd.Parameters.AddWithValue("@StartTime", L.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", L.EndTime);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if the query run successfully the the value of rows will be greater than zero slse if value will be 0

                if(rows > 0)
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

        //Method to Delete data from Database

        public bool DeleteLecturer(LectureClass L)
        {
            //create a default value and set its value to false
            bool isSuccess = false;

            //creating Sql connection

                        SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();

            try
            {
                //sql to Delete data
                string sql = "Delete from Lecturer where EmployeeID=@EmployeeID";

                //creating Sql command

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", L.EmployeeID);

                //open connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                ////if the query run successfully the the value of rows will be greater than zero slse if value will be 0
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //close connection
                conn.Close();
            }
            return isSuccess;
        }
    }
}
