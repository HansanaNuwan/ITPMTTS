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
    public partial class Subject : Form
    {
        SubjectClass s = new SubjectClass();

        public string OfferdYear, OfferdSemester, SubjectName, SubjectCode, NoOfLectureHours, NoOfTutorialHours, NoOfLabHours, NoOfEvaluationHours;

        public Subject()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rd2Sem_CheckedChanged(object sender, EventArgs e)
        {
           // OfferdSemester = "2nd semester";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageSubject ms = new manageSubject();
            ms.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            s.OfferdYear = cmbOffYear.SelectedItem.ToString();
           
         
            if (rd1sem.Checked)
            {
                s.OfferdSemester = 1;
            }else if (rd2Sem.Checked)
            {
                s.OfferdSemester = 2;
            }
            s.SubjectName = txtSubName.Text.ToString();
            s.SubjectCode = txtSubCode.Text.ToString();
            s.NoOfLectureHours = int.Parse(upLecHours.Text.ToString());
            s.NoOfTutorialHours = int.Parse(upTuteHours.Text.ToString());
            s.NoOfLabHours = int.Parse(upLabHours.Text.ToString());
            s.NoOfEvaluationHours = int.Parse(upEvaluHours.Text.ToString());

            //inserting Data into database using the method we created 

            bool success = s.insertSubject(s);

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
                MessageBox.Show("Failed to add subject details.Try Again");
            }
        }

        //add clear data

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

        private bool isformValid()
        {
            if (cmbOffYear.Text.ToString().Trim() == string.Empty || rd1sem.Text.ToString().Trim() == string.Empty || txtSubName.Text.Trim() == string.Empty || txtSubCode.Text.Trim() == string.Empty || upLecHours.Text.Trim() == string.Empty || upTuteHours.Text.Trim() == string.Empty || upLabHours.Text.Trim() == string.Empty || upEvaluHours.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Please fill out the all field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

  

    }



}
