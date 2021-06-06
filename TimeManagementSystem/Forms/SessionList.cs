using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TimeManagementSystem
{
    public partial class SessionList : Form
    {
        public SessionList()
        {
            InitializeComponent();
        }


        private static SessionList __getSessionList;

        public static SessionList GetSessionsList
        {
            get { return __getSessionList; }
            set { __getSessionList = value; }  
        }

        
        private void SessionList_Load(object sender, EventArgs e)
        {
            DGVSession.DataSource = GetSessionListData();

            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            DGVSession.Columns.Insert(0, chkbox);
            GetSessionsList = this;
        }

        private DataTable GetSessionListData()
        {
            DataTable dt = new DataTable();

            string connString = Classes.ConnectionStrings.TimeTableSystem; 

            using (SQLiteConnection con = new Classes.SqliteHelper().GetSQLiteConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand("Select * from Session", con))
                {
                    con.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    dt.Load(reader);
                }
            }

            return dt;

        }

        private void DGVSession_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public class SessonData
        {
            public string id, lecture1, lecture2, SubjectCode, SubjectName, GroupID, Tag, NoOfStudents, Duration, Typename, NewId;
        }

        void add(string typename)
        {
            List<String> ids = new List<string>();
            foreach (DataGridViewRow dr in DGVSession.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                {
                    ids.Add(dr.Cells[1].Value.ToString());
                }
            }

            //if need items limitation
            if (ids.Count < 2)
            {
                statusLable.Text = "Select More than 1 Session !";
                return;
            }

            string connString = Classes.ConnectionStrings.TimeTableSystem;

            // string connString = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SQLiteConnection sqlconn = new Classes.SqliteHelper().GetSQLiteConnection();
            // SQLiteConnection sqlconn2 = new Classes.SqliteHelper().GetSQLiteConnection();



            try
            {
                sqlconn.Open();

                String q1 = $"select * from  sessionCat where LecID in ({String.Join(",", ids)})";
                using (SQLiteCommand sqlcomm1 = new SQLiteCommand(q1, sqlconn))
                {
                    using (SQLiteDataReader rdr = sqlcomm1.ExecuteReader())
                        if (rdr.Read())
                        {
                            statusLable.Text = "Duplicate data";
                            return;
                        }
                }

                String newid = "";
                String q2 = $@"
select idChar,  CAST(incremnt as varchar) [newid] from idNumbers where idChar = 'S';
update idNumbers set incremnt = incremnt + 1 where idChar = 'S';";
                using (SQLiteCommand sqlcomm2 = new SQLiteCommand(q2, sqlconn))
                {
                    using (SQLiteDataReader rdr2 = sqlcomm2.ExecuteReader())
                        if (rdr2.Read())
                        {
                            newid = rdr2["idChar"].ToString() + rdr2["newid"].ToString();
                        }
                }

                if (newid == "")
                {
                    statusLable.Text = "Id genarate fail!";
                    return;
                }
                //sqlconn.Close();

                string selectq = $@"
 select id,[Lecture1],[Lecture2],[SubjectCode],[SubjectName]
      ,[GroupID],[Tag],[NoOfStudent],[Duration],'{typename}' [Type],'{newid}' [newid] from Session where id in ({ String.Join(",", ids)}); ";

                SQLiteCommand sqlcomm4 = new SQLiteCommand(selectq, sqlconn);
                //sqlconn.Open();

                List<SessonData> ins_ids = new List<SessonData>();
                using (SQLiteDataReader reader = sqlcomm4.ExecuteReader())
                {
                    ins_ids = new List<SessonData>();
                    while (reader.Read())
                    {
                        ins_ids.Add(new SessonData()
                        {
                            id = reader["id"].ToString(),
                            lecture1 = reader["Lecture1"].ToString(),
                            lecture2 = reader["Lecture2"].ToString(),
                            SubjectCode = reader["SubjectCode"].ToString(),
                            SubjectName = reader["SubjectName"].ToString(),
                            GroupID = reader["GroupID"].ToString(),
                            Tag = reader["Tag"].ToString(),
                            NoOfStudents = reader["NoOfStudent"].ToString(),
                            Duration = reader["Duration"].ToString(),
                            Typename = typename,
                            NewId = newid

                        });
                    }
                }
                foreach (SessonData ssdata in ins_ids)
                {
                    String sqlquery = $@"
INSERT INTO sessionCat
           (LecID, Lecture1, Lecture2, SubjectCode, SubjectName
           , GroupID, Tag, NoOfStudent, Duration, Type, SessionID)
values(@ID,@Lecture1,@Lecture2,@SubjectCode,@SubjectName,@GroupID,@Tag,@NoOfStudent,@Duration,@Type,@SessionID);
   
";

                    SQLiteCommand sqlcomm = new SQLiteCommand(sqlquery, sqlconn);

                    sqlcomm.Parameters.AddWithValue("@ID", ssdata.id);
                    sqlcomm.Parameters.AddWithValue("@Lecture1", ssdata.lecture1);
                    sqlcomm.Parameters.AddWithValue("@Lecture2", ssdata.lecture2);
                    sqlcomm.Parameters.AddWithValue("@SubjectCode", ssdata.SubjectCode);
                    sqlcomm.Parameters.AddWithValue("@SubjectName", ssdata.SubjectName);
                    sqlcomm.Parameters.AddWithValue("@GroupID", ssdata.GroupID);
                    sqlcomm.Parameters.AddWithValue("@Tag", ssdata.Tag);
                    sqlcomm.Parameters.AddWithValue("@NoOfStudent", ssdata.NoOfStudents);
                    sqlcomm.Parameters.AddWithValue("@Duration", ssdata.Duration);
                    sqlcomm.Parameters.AddWithValue("@Type", typename);
                    sqlcomm.Parameters.AddWithValue("@SessionID", newid);

                    sqlcomm.ExecuteNonQuery();

                    //sqlconn2.Open();

                    /*  SQLiteTransaction tran = sqlconn2.BeginTransaction();
                      sqlcomm.Transaction = tran;
                      try
                      {
                          statusLable.Text = "Insert success";
                          tran.Commit();
                      }
                      catch (Exception ex1)
                      {
                          if (tran != null)
                              tran.Rollback();
                      }
                      finally
                      {
                          sqlconn2.Close();
                      } */
                    //}
                    statusLable.Text = "Insert success";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCons_Click(object sender, EventArgs e)
        {


            add("Consecutive");




        }

        private void button2_Click(object sender, EventArgs e)
        {

            add("Parallel");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            add("NonOverlapping");

        }

        private void SessionList_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetSessionsList = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            if (Sessions.GetSessions == null)
            {
                Sessions.GetSessions = new Sessions();
                // SessionList.GetSessionsList.MdiParent = this;
                Sessions.GetSessions.Show();
            }
            else
            {
                
                Sessions.GetSessions.Show(); 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
