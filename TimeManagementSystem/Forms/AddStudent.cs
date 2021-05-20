using System;
using System.Windows.Forms;
using TimeManagementSystem.CRUD;

namespace TimeManagementSystem
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        ManageStudentClass m = new ManageStudentClass();


        private void AddStudent_Load(object sender, EventArgs e)
        {

            btnAdd.Enabled = false;

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
            btnAdd.Enabled = false;

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

        }

        //method to clear fields
        public void Clear()
        {

            CBYearSem.Text = "";
            CBProgramme.Text = "";
            NMGroupNo.Value = 0;
            NMSubGroupNo.Value = 0;
            lblGroupID.Text = "";
            lblSGroupID.Text = "";

            btnAdd.Enabled = false;

        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string ys = CBYearSem.Text;
            string pg = CBProgramme.Text;
            string gn = Convert.ToString(NMGroupNo.Value);
            string sgn = Convert.ToString(NMSubGroupNo.Value);

            lblGroupID.Text = ys + "." + pg + "." + gn;

            lblSGroupID.Text = ys + "." + pg + "." + gn + "." + sgn;


            btnAdd.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ManageStudent stdm = new ManageStudent();
            stdm.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
