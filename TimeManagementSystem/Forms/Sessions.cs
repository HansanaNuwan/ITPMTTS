using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManagementSystem
{
    public partial class Sessions : Form
    {
        public Sessions()
        {
            InitializeComponent();
        }

        string connString = Classes.ConnectionStrings.TimeTableSystem;

        //select session
        public DataTable SelectSessions(String session)
        {
            //DB connection
            SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();
            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "Select * from sessionCat where Type = @session";

                //creating cmd using sql and conn
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@session", session);
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

        SessionType SelectedSessionType;
        public DataTable SelectSessions(SessionType session)
        {
            SelectedSessionType = session;
            //DB connection
                        SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();
            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "Select * from sessionCat where Type = @session";

                //creating cmd using sql and conn
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@session", session.ToString());
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
       


        private void Sessions_Load(object sender, EventArgs e)
        {
            label2.Text = "Press any button";
            GetSessions = this;
        }


        private void btnCons_Click(object sender, EventArgs e)
        {
            SetSelectedButton(sender);
            DataTable dt = SelectSessions(SessionType.consecutive);
            dataGridView1.DataSource = dt;

            label2.Text = "Consecutive Sessions";
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            SetSelectedButton(sender);
         
            DataTable dt = SelectSessions(SessionType.parallel);
            dataGridView1.DataSource = dt;

           label2.Text = "Parallel Sessions";
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            SetSelectedButton(sender);
          
            DataTable dt = SelectSessions(SessionType.NonOverlapping);
            dataGridView1.DataSource = dt;

            label2.Text = "Non Overlapping Sessions";
        }

        
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
              

                DataGridViewRow selected = dataGridView1.SelectedRows[0];
                if (selected != null)
                {
                    //delete

                                 SQLiteConnection conn = new Classes.SqliteHelper().GetSQLiteConnection();
                     DataTable dt = new DataTable();

                     try   
                     {
                       String sessionID = selected.Cells[11].Value.ToString();
                         //sql query
                         string sql = "Delete sessionCat where sessionID = @sessionID";

                         //creating cmd using sql and conn
                         SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@sessionID", sessionID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        dataGridView1.DataSource= SelectSessions(SelectedSessionType);
                     MessageBox.Show("Deleted From Database !");
                    }
                    catch (Exception ex)
                     {

                     }
                     finally
                     {
                         conn.Close();

                     }

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnRemove.Enabled = dataGridView1.SelectedRows.Count > 0;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Hide();
            if (SessionList.GetSessionsList == null)
            {
                SessionList.GetSessionsList = new SessionList();
                // SessionList.GetSessionsList.MdiParent = this;
                SessionList.GetSessionsList.Show();
            }
            else
            {
                SessionList.GetSessionsList.Show();
            }

        }

        private static Sessions __getSessions;

        public static Sessions GetSessions
        {
            get { return __getSessions; }
            set { __getSessions = value; }
        }

        private void Sessions_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetSessions = null;
        }

        void SetSelectedButton(object sender)
        {
            if (sender is Button)
            {
                Button selected = sender as Button;
                foreach (object btn in pnlbtngroup1.Controls)
                {
                    if (btn is Button && btn!=selected)
                    {
                        ((Button)btn).FlatStyle = FlatStyle.Standard;
                    }
                }
                selected.FlatStyle = FlatStyle.Popup;
            }

        }
    }
}



