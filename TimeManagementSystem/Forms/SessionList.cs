using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Session", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dt.Load(reader);
                }
            }

            return dt;

        }

        private void DGVSession_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            SqlConnection sqlconn = new SqlConnection(connString);



            try
            {
                String sqlquery = $@"
if exists(select * from  sessionCat where LecID in ({String.Join(",", ids)}))
begin
    select 'Duplicate data' [msg]
end
else
begin


declare @id varchar(10)

select @id = idChar + CAST(incremnt as varchar) from idNumbers where idChar = 'S'
update idNumbers set incremnt = incremnt + 1 where idChar = 'S'

INSERT INTO sessionCat
           (LecID, Lecture1, Lecture2, SubjectCode, SubjectName
           , GroupID, Tag, NoOfStudent, Duration, Type, SessionID)
 select id,[Lecture1],[Lecture2],[SubjectCode],[SubjectName]
      ,[GroupID],[Tag],[NoOfStudent],[Duration],'{typename}',@id from Session where id in ({String.Join(",", ids)})
   
    select 'Insert success' [msg]
end";

                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                /*
                sqlcomm.Parameters.AddWithValue("@ID", dr.Cells[2].Value);
                sqlcomm.Parameters.AddWithValue("@Lecture1", dr.Cells[3].Value);
                sqlcomm.Parameters.AddWithValue("@Lecture2", dr.Cells[4].Value);
                sqlcomm.Parameters.AddWithValue("@SubjectCode", dr.Cells[5].Value);
                sqlcomm.Parameters.AddWithValue("@SubjectName", dr.Cells[6].Value);
                sqlcomm.Parameters.AddWithValue("@GroupID", dr.Cells[7].Value);
                sqlcomm.Parameters.AddWithValue("@Tag", dr.Cells[8].Value);
                sqlcomm.Parameters.AddWithValue("@NoOfStudent", dr.Cells[9].Value);
                sqlcomm.Parameters.AddWithValue("@Duration", dr.Cells[10].Value);
                sqlcomm.Parameters.AddWithValue("@Type", "Consecutive");
                //sqlcomm.Parameters.AddWithValue("@SessionID", "CO"+ i);*/


                sqlconn.Open();
                SqlTransaction tran = sqlconn.BeginTransaction();
                sqlcomm.Transaction = tran; 
                try
                {
                    
                    using (SqlDataReader reader = sqlcomm.ExecuteReader())
                        if (reader.Read())
                        {
                            statusLable.Text = reader["msg"].ToString(); 
                        }
                    tran.Commit();

                }
                catch (Exception ex1)
                {
                    if (tran != null)
                        tran.Rollback();
                }
                finally
                {
                    sqlconn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCons_Click(object sender, EventArgs e)
        {


            add("consecutive");




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
    }
}
