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
    public partial class manageSubject : Form
    {
        SubjectClass s = new SubjectClass();

        public manageSubject()
        {
            InitializeComponent();
        }

        private void manageSubject_Load(object sender, EventArgs e)
        {
            //load data to gradview
             DataTable dt = s.Select();
             dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

           
            cmbOffYear.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            string temp = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            if (temp.Equals("1"))
            {
                rd1sem.Checked = true;
                rd2Sem.Checked = false;
            }
            else if(temp.Equals("2"))
            {
                rd1sem.Checked = false;
                rd2Sem.Checked = true;
            }
            txtSubName.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            txtSubCode.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            upLecHours.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            upTuteHours.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            upLabHours.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            upEvaluHours.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the data from textboxes

            s.OfferdYear = cmbOffYear.Text;

            if (rd1sem.Checked)
            {
                s.OfferdSemester = 1;
            }else if (rd2Sem.Checked)
            {
                s.OfferdSemester = 2;
            }

            s.SubjectName = txtSubName.Text;
            s.SubjectCode = txtSubCode.Text;
            s.NoOfLectureHours = int.Parse(upLecHours.Text);
            s.NoOfTutorialHours = int.Parse(upTuteHours.Text);
            s.NoOfLabHours = int.Parse(upLabHours.Text);
            s.NoOfEvaluationHours = int.Parse(upEvaluHours.Text);

            //update data in database

            bool success = s.UpdateSubject(s);

            if (success == true)
            {
                MessageBox.Show("Successfully Updated.");

                //load data into gridview
                DataTable dt = s.Select();
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update Details.Try Again.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get the Subjectcode from an application
            s.SubjectCode = Convert.ToString(txtSubCode.Text.ToString());

            bool success = s.DeleteSubject(s);

            if (success == true)
            {
                MessageBox.Show("Successfully Deleted.");

                //refresh the gridview
                DataTable dt = s.Select();
                dataGridView1.DataSource = dt;
                Clear();

            }
            else
            {
                MessageBox.Show("Failed to Delete.Try Again.");
            }
        }

        //method tto clear fields

        public void Clear()
        {
            cmbOffYear.Text = "";
            rd1sem.Checked = false;
            rd2Sem.Checked = false;
            txtSubName.Text = "";
            txtSubCode.Text = "";
            upLecHours.Text = "";
            upTuteHours.Text = "";
            upLabHours.Text = "";
            upEvaluHours.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Subject s = new Subject();
            s.Show();
            this.Close();
        }
    }
}
