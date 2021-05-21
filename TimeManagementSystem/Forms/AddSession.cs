using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeManagementSystem.CRUD;

namespace TimeManagementSystem
{
    public partial class Session : Form
    {
        public Session()
        {
            InitializeComponent();
        }

        SQLiteConnection con = new Classes.SqliteHelper().GetSQLiteConnection();

        SessionClass S = new SessionClass();

        //public String Lecture1, Lecture2, SubjectCode, SubjectName, GroupID, Tag, NoOfStudent, Duration;

        private void btnSave_Click(object sender, EventArgs e)
        {
            S.Lecture1 = cmbSelectLec.Text;
            S.Lecture2 = txtSelectLec.Text;
            S.SubjectCode = txtSubCode.Text;
            S.SubjectName = cmbSelectSubject.Text;
            S.GroupID = cmbSelectGroup.Text;
            S.Tag = cmbSelectTag.Text;
            S.NoOfStudent = txtNoStudent.Text;
            S.Duration = txtDuration.Text;

            //inserting Data into database using the method we created 

            bool success = S.insertSession(S);

            if (success == true)
            {
                //successfully inserted
                MessageBox.Show("Successfully Inserted");

                //call the method here
               Clear();
            }
            else
            {
                //failed to add data
                MessageBox.Show("Failed to add Session details.Try Again");
            }

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            manageSession md = new manageSession();
            md.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtID.Text = "";
            cmbSelectLec.Text = "";
            txtSelectLec.Text = "";
            cmbSelectSubject.Text = "";
            txtSubCode.Text = "";
            cmbSelectGroup.Text = "";
            cmbSelectTag.Text = "";
            txtNoStudent.Text = "";
            txtDuration.Text = "";
            
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            DashBoard tb = new DashBoard();
            tb.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBoard D = new DashBoard();
            D.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNext_Click_1(object sender, EventArgs e)
        {
            manageSession mg = new manageSession();
            mg.Show();
        }

        private void BtmgSession_Click(object sender, EventArgs e)
        {
            manageSession mg = new manageSession();
            mg.Show();
            this.Close();
        }

        private bool isformValid()
        {
            if (cmbSelectLec.Text.ToString().Trim() == string.Empty || txtSubCode.Text.ToString().Trim() == string.Empty || cmbSelectSubject.Text.Trim() == string.Empty || cmbSelectGroup.Text.Trim() == string.Empty || cmbSelectTag.Text.Trim() == string.Empty || txtNoStudent.Text.Trim() == string.Empty || txtDuration.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out the all field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void fillcmbSelectLec()
        {
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("select LectureName from Lecturer", con);
            SQLiteDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("LectureName", typeof(string));
            dt.Load(rdr);
            cmbSelectLec.ValueMember = "LectureName";
            cmbSelectLec.DataSource = dt;
            con.Close();
        }

        public void fillcmbSelectSub()
        {
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("select SubjectName from Subject", con);
            SQLiteDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SubjectName", typeof(string));
            dt.Load(rdr);
            cmbSelectSubject.ValueMember = "SubjectName";
            cmbSelectSubject.DataSource = dt;
            con.Close();
        }

        public void filltxtSubCode()
        {
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("select SubjectCode from Subject", con);
            SQLiteDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SubjectCode", typeof(string));
            dt.Load(rdr);
            txtSubCode.ValueMember = "SubjectCode";
            txtSubCode.DataSource = dt;
            con.Close();
        }
        private void Session_Load(object sender, EventArgs e)
        {
            fillcmbSelectLec();
            fillcmbSelectSub();
            filltxtSubCode();
        }
    }

}
