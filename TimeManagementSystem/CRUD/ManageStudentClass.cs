using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace TimeManagementSystem.CRUD
{
    class ManageStudentClass
    {
        //getters and setter 
        //acts as an data carrier
        public int ID { get; set; }
        public string AcademicYearSemester { get; set; }
        public string Program { get; set; }
        public int GroupNo { get; set; }
        public int SubGroupNo { get; set; }
        public string GroupID { get; set; }
        public string SubGroupID { get; set; }

        static string myconnstrng = Classes.ConnectionStrings.TimeTableSystem;

        //selecting Data  from database
        public DataTable Select()
        {
            //DB connection
                        SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();
            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "Select * from StudentManage";

                //creating cmd using sql and conn
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                //creating sql data adapted using cmd
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return dt;

        }

        //Insering data into the database
        public bool Insert(ManageStudentClass m)
        {
            //creating a default return type
            bool isSuccess = false;

            //connect db
                        SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();
            try
            {
                //sql to insert data
                string sql = "Insert into StudentManage (AcademicYearSemester, Programme ,GroupNo,SubGroupNo ,GroupID , SubGroupID) values (@AcademicYearSemester, @Programme ,@GroupNo,@SubGroupNo ,@GroupID , @SubGroupID)";
                //creating sql using sql and conn
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@AcademicYearSemester", m.AcademicYearSemester);
                cmd.Parameters.AddWithValue("@Programme", m.Program);
                cmd.Parameters.AddWithValue("@GroupNo", m.GroupNo);
                cmd.Parameters.AddWithValue("@SubGroupNo", m.SubGroupNo);
                cmd.Parameters.AddWithValue("@GroupID", m.GroupID);
                cmd.Parameters.AddWithValue("@SubGroupID", m.SubGroupID);

                //open connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if code success value of rows will greater than zero else its zero
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

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;


        }
        //update data in database
        public bool Update(ManageStudentClass m)
        {
            //default return type and set its value to false
            bool isSuccess = false;

                        SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();
            try
            {
                //sql to update data
                string sql = "Update StudentManage set AcademicYearSemester = @AcademicYearSemester, Programme = @Programme ,GroupNo = @GroupNo,SubGroupNo = @SubGroupNo ,GroupID = @GroupID , SubGroupID = @SubGroupID where ID = @ID ";

                //sql
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                //create parameters to add value
                cmd.Parameters.AddWithValue("@AcademicYearSemester", m.AcademicYearSemester);
                cmd.Parameters.AddWithValue("@Programme", m.Program);
                cmd.Parameters.AddWithValue("@GroupNo", m.GroupNo);
                cmd.Parameters.AddWithValue("@SubGroupNo", m.SubGroupNo);
                cmd.Parameters.AddWithValue("@GroupID", m.GroupID);
                cmd.Parameters.AddWithValue("@SubGroupID", m.SubGroupID);
                cmd.Parameters.AddWithValue("ID", m.ID);

                //open database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
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

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        //method to delete data in DB
        public bool Delete(ManageStudentClass m)
        {

            //create a default retun value and set it value to false
            bool isSuccess = false;
            //create sql connection
                        SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();
            try
            {
                //sql to delete data
                string sql = "Delete from StudentManage where ID = @ID";

                //creating sql command
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", m.ID);
                //open connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
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

            }
            finally
            {

                conn.Close();
            }
            return isSuccess;

        }
    }
}
