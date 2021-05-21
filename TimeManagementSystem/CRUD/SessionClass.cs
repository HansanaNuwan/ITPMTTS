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
    class SessionClass
    {

        //getters and setters
        //Acts as Data carrier in our applicaion
        public int ID { get; set; }

        public string Lecture1 { get; set; }

        public string Lecture2 { get; set; }

        public string SubjectCode { get; set; }

        public string SubjectName { get; set; }

        public string GroupID { get; set; }

        public string Tag { get; set; }

        public string NoOfStudent { get; set; }

        public string Duration { get; set; }


        static string myconnstrng = Classes.ConnectionStrings.TBMS;

        //selecting data from database
        public DataTable Select()
        {
            //database connection
            SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();

            DataTable dt = new DataTable();

            try
            {
                //writing sql query
                string sql = "Select * from Session";

                //creating cmd using sql and conn
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                //creating Sql Data Adapter using cmd
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
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

        public bool insertSession(SessionClass S)
        {
            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //connect database
            SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();

            try
            {
                //creating a Sql query ti insert data
                string sql = "Insert into Session(Lecture1, Lecture2, SubjectCode, SubjectName, GroupID, Tag, NoOfStudent, Duration) VALUES(@Lecture1, @Lecture2, @SubjectCode, @SubjectName, @GroupID, @Tag, @NoOfStudent, @Duration)";

                //creatng a Sql command using sql and cmd

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                //cmd.Parameters.AddWithValue("@ID", s.ID);
                cmd.Parameters.AddWithValue("@Lecture1", S.Lecture1);
                cmd.Parameters.AddWithValue("@Lecture2", S.Lecture2);
                cmd.Parameters.AddWithValue("@SubjectCode", S.SubjectCode);
                cmd.Parameters.AddWithValue("@SubjectName", S.SubjectName);
                cmd.Parameters.AddWithValue("@GroupID", S.GroupID);
                cmd.Parameters.AddWithValue("@Tag", S.Tag);
                cmd.Parameters.AddWithValue("@NoOfStudent", S.NoOfStudent);
                cmd.Parameters.AddWithValue("@Duration", S.Duration);

                // connection open here

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully the the value of rows will be greater than zero else if value will be 0

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

        public bool UpdateSession(SessionClass S)
        {
            //create a default return type and set its default values to false

            bool isSuccess = false;
            SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();

            try
            {
                string sql = "update Session set Lecture1 = @Lecture1, Lecture2 = @Lecture2, SubjectCode = @SubjectCode, SubjectName = @SubjectName,  GroupID = @GroupID, Tag = @Tag, NoOfStudent = @NoOfStudent, Duration = @Duration  where ID = @ID";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                //create paramters to add values

                //cmd.Parameters.AddWithValue("@ID", s.ID);
                cmd.Parameters.AddWithValue("@Lecture1", S.Lecture1);
                cmd.Parameters.AddWithValue("@Lecture2", S.Lecture2);
                cmd.Parameters.AddWithValue("@SubjectCode", S.SubjectCode);
                cmd.Parameters.AddWithValue("@SubjectName", S.SubjectName);
                cmd.Parameters.AddWithValue("@GroupID", S.GroupID);
                cmd.Parameters.AddWithValue("@Tag", S.Tag);
                cmd.Parameters.AddWithValue("@NoOfStudent", S.NoOfStudent);
                cmd.Parameters.AddWithValue("@Duration", S.Duration);
                cmd.Parameters.AddWithValue("@ID", S.ID);

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


        public bool DeleteSession(SessionClass S)
        {
            //create a default value and set its value to false
            bool isSuccess = false;

            //creating Sql connection

            SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();


            try
            {
                //sql to delete Data
                string sql = "Delete from Session where ID = @ID";


                //creating sql command

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", S.ID);

                //open connection
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
                //close the connection
                conn.Close();
            }
            return isSuccess;
        }
    }
}
