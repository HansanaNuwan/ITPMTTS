using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeManagementSystem.CRUD;

namespace TimeManagementSystem
{
    public partial class manageLecture : Form
    {
        public manageLecture()
        {
            InitializeComponent();
        }

        LectureClass L = new LectureClass();

        private void manageLecture_Load(object sender, EventArgs e)
        {
            //load data to gradview
            DataTable dt = L.Select();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from data grid view and load into the textbox recpectively
            int rowIndex = e.RowIndex;
            txtEmpID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtLecName.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            cmbFaculty.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            cmbDept.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            cmbCenter.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            cmbBuld.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            cmbLevel.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            txtRank.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            cmbDay.Text = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
            txtStartTime.Text = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
            txtEndTime.Text = dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the data from textboxes

            L.EmployeeID = int.Parse(txtEmpID.Text);
            L.LectureName = txtLecName.Text;
            L.Faculty = cmbFaculty.Text;
            L.Department = cmbDept.Text;
            L.Center = cmbCenter.Text;
            L.Building = cmbBuld.Text;
            L.Level = int.Parse(cmbLevel.Text);
            L.Rank = txtRank.Text;
            L.SelectDay = cmbDay.Text;
            L.StartTime = txtStartTime.Text;
            L.EndTime = txtEndTime.Text;

            //update data in database

            bool success = L.UpdateLecturer(L);

            if(success == true)
            {
                MessageBox.Show("Successfully Updated.");
                
                //load data into gridview
                DataTable dt = L.Select();
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update Details.Try Again.");
            }

        }

        //method tto clear fields

        public void Clear()
        {
            txtEmpID.Text = "";
            txtLecName.Text = "";
            cmbFaculty.Text = "";
            cmbDept.Text = "";
            cmbCenter.Text = "";
            cmbBuld.Text = "";
            cmbLevel.Text = "";
            txtRank.Text = "";
            cmbDay.Text = "";
            txtStartTime.Text = "";
            txtEndTime.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get the employeeID from an application
            L.EmployeeID = Convert.ToInt32(txtEmpID.Text);

            bool success = L.DeleteLecturer(L);

            if(success == true)
            {
                MessageBox.Show("Successfully Deleted.");

                //refresh the gridview
                DataTable dt = L.Select();
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
            Lecturer form = new Lecturer();
            form.Show();
            this.Close();
        }
    }
}
