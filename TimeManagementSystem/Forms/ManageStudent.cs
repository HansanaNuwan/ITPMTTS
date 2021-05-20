using System;
using System.Data;
using System.Windows.Forms;
using TimeManagementSystem.CRUD;

namespace TimeManagementSystem
{
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        ManageStudentClass m = new ManageStudentClass();

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string ys = CBYearSem.Text;
            string pg = CBProgramme.Text;
            string gn = Convert.ToString(NMGroupNo.Value);
            string sgn = Convert.ToString(NMSubGroupNo.Value);

            lblGroupID.Text = ys + "." + pg + "." + gn;

            lblSGroupID.Text = ys + "." + pg + "." + gn + "." + sgn;

            btnUpdate.Enabled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get the values from the input fields

            m.AcademicYearSemester = CBYearSem.Text;
            m.Program = CBProgramme.Text;
            m.GroupNo = Convert.ToInt32(NMGroupNo.Value);
            m.SubGroupNo = Convert.ToInt32(NMSubGroupNo.Value);
            m.GroupID = lblGroupID.Text;
            m.SubGroupID = lblSGroupID.Text;

            //inserting data into database
            bool success = m.Insert(m);

            if (success == true)
            {
                //insert success
                MessageBox.Show("Student Group Added !");
                //clear the fields
                Clear();

            }
            else
            {
                //if failed
                MessageBox.Show("Failed to Add Student Group !");
            }
            //load data to table
            DataTable dt = m.Select();
            dgvManageStudent.DataSource = dt;

        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            //load data to table
            DataTable dt = m.Select();
            dgvManageStudent.DataSource = dt;

            btnUpdate.Enabled = false;

        }
        //method to clear fields
        public void Clear()
        {
            TBID.Text = "";
            CBYearSem.Text = "";
            CBProgramme.Text = "";
            NMGroupNo.Value = 0;
            NMSubGroupNo.Value = 0;
            lblGroupID.Text = "";
            lblSGroupID.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //call clear method
            Clear();
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the data from text boxes
            m.ID = int.Parse(TBID.Text);
            m.AcademicYearSemester = CBYearSem.Text;
            m.Program = CBProgramme.Text;
            m.GroupNo = Convert.ToInt32(NMGroupNo.Value);
            m.SubGroupNo = Convert.ToInt32(NMSubGroupNo.Value);
            m.GroupID = lblGroupID.Text;
            m.SubGroupID = lblSGroupID.Text;

            //update data in database
            bool success = m.Update(m);
            if (success == true)
            {
                //insert success
                MessageBox.Show("data updated !");
                //load data to table
                DataTable dt = m.Select();
                dgvManageStudent.DataSource = dt;
                //clear the fields
                Clear();

            }
            else
            {
                //if failed
                MessageBox.Show("Failed to update data !");
            }
            btnUpdate.Enabled = false;



        }

        private void dgvManageStudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get and load data to input fields
            //identify the row which mouse is clicked
            int rowIndex = e.RowIndex;

            TBID.Text = dgvManageStudent.Rows[rowIndex].Cells[0].Value.ToString();
            CBYearSem.Text = dgvManageStudent.Rows[rowIndex].Cells[1].Value.ToString();
            CBProgramme.Text = dgvManageStudent.Rows[rowIndex].Cells[2].Value.ToString();
            NMGroupNo.Value = Convert.ToInt32(dgvManageStudent.Rows[rowIndex].Cells[3].Value.ToString());
            NMSubGroupNo.Value = Convert.ToInt32(dgvManageStudent.Rows[rowIndex].Cells[4].Value.ToString());
            lblGroupID.Text = dgvManageStudent.Rows[rowIndex].Cells[5].Value.ToString();
            lblSGroupID.Text = dgvManageStudent.Rows[rowIndex].Cells[6].Value.ToString();




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get the data from the text boxes
            m.ID = Convert.ToInt32(TBID.Text);

            //call delete method
            bool success = m.Delete(m);

            if (success == true)
            {
                //insert success
                MessageBox.Show("Data Deleted !");

                //load data to table
                DataTable dt = m.Select();
                dgvManageStudent.DataSource = dt;

                //clear input fields
                Clear();


            }
            else
            {
                //if failed
                MessageBox.Show("Failed to Delete data !");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent stdm = new AddStudent();
            stdm.Show();

            this.Close();
        }

        private void dgvManageStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
