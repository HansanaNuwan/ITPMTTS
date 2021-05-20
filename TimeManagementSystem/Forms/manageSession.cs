using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeManagementSystem.CRUD;

namespace TimeManagementSystem
{
    public partial class manageSession : Form
    {
        public manageSession()
        {
            InitializeComponent();
        }

        SessionClass S = new SessionClass();


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from data grid view and load into the textbox recpectively
            int rowIndex = e.RowIndex;
            txtID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            cmbSelectLec.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtSelectLec.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtSubCode.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            cmbSelectSubject.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            cmbSelectGroup.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            cmbSelectTag.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            txtNoStudent.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            txtDuration.Text = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the data from textboxes
            S.ID = int.Parse(txtID.Text);
            S.Lecture1 = cmbSelectLec.Text;
            S.Lecture2 = txtSelectLec.Text;
            S.SubjectCode = txtSubCode.Text;
            S.SubjectName = cmbSelectSubject.Text;
            S.GroupID = cmbSelectGroup.Text;
            S.Tag = cmbSelectTag.Text;
            S.NoOfStudent = txtNoStudent.Text;
            S.Duration = txtDuration.Text;

            //update data in database

            bool success = S.UpdateSession(S);

            if (success == true)
            {
                MessageBox.Show("Successfully Updated.");

                //load data into gridview
                DataTable dt = S.Select();
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update Details.Try Again.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get the ID from an application
            S.ID = Convert.ToInt32(txtID.Text);

            bool success = S.DeleteSession(S);

            if (success == true)
            {
                MessageBox.Show("Successfully Deleted.");

                //refresh the gridview
                DataTable dt = S.Select();
                dataGridView1.DataSource = dt;
                Clear();

            }
            else
            {
                MessageBox.Show("Failed to Delete.Try Again.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Session ad = new Session();
            ad.Show();
            this.Close();
        }

        public void Clear()
        {
            txtID.Text = "";
            cmbSelectLec.Text = "";
            txtSelectLec.Text = "";
            txtSubCode.Text = "";
            cmbSelectSubject.Text = "";
            cmbSelectGroup.Text = "";
            cmbSelectTag.Text = "";
            txtNoStudent.Text = "";
            txtDuration.Text = "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            Session ad = new Session();
            ad.Show();
            this.Close();
        }

        private void manageSession_Load(object sender, EventArgs e)
        {
            //load data to data gridview
            DataTable dt = S.Select();
            dataGridView1.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get tha value from textBox
            string keyword = txtSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Session where Lecture1 LIKE '%" + keyword + "%' OR SubjectCode LIKE '%" + keyword + "%' OR SubjectName LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //get tha value from textBox
            string keyword = txtSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Session where Lecture1 LIKE '%" + keyword + "%' OR SubjectCode LIKE '%" + keyword + "%' OR SubjectName LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
