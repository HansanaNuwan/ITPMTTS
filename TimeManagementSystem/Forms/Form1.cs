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
    public partial class Lecturer : Form
    {
        public Lecturer()
        {
            InitializeComponent();
        }

        LectureClass L = new LectureClass();

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            L.EmployeeID = int.Parse(textBox1.Text);
            L.LectureName = textBox2.Text;
            L.Faculty = comboBox1.SelectedItem.ToString();
            L.Department = comboBox2.SelectedItem.ToString();
            L.Center = comboBox3.SelectedItem.ToString();
            L.Building = comboBox4.SelectedItem.ToString();
            L.Level = int.Parse(comboBox5.SelectedItem.ToString());
            L.Rank = textBox3.Text;
            L.SelectDay = comboBox6.SelectedItem.ToString();
            L.StartTime = textBox5.Text;
            L.EndTime = textBox6.Text;
           

            //inserting Data into database using the method we created 

            bool success = L.InsertLecturer(L);

            if(success == true)
            {
                //successfully inserted
                MessageBox.Show("Successfully Inserted");

                //call the method here
                Clear();
            }
            else
            {
                //failed to add data
                MessageBox.Show("Failed to add lecturer details.Try Again");
            }
        }

        //method to clear fields

        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            textBox3.Text = "";
            comboBox6.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private bool isformValid()
        {
            if (textBox1.Text.ToString().Trim() == string.Empty || textBox2.Text.ToString().Trim() == string.Empty || comboBox1.Text.Trim() == string.Empty || comboBox2.Text.Trim() == string.Empty || comboBox3.Text.Trim() == string.Empty || comboBox4.Text.Trim() == string.Empty || comboBox5.Text.Trim() == string.Empty || comboBox6.Text.Trim() == string.Empty || textBox5.Text.Trim() == string.Empty || textBox6.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out the all field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            manageLecture lec = new manageLecture();
            lec.Show();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isformValid())
            {
                string Level = comboBox5.Text.Trim();
                string EmployeeID = textBox1.Text;
                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                textBox3.ForeColor = SystemColors.ControlText;
                textBox3.Text = Level + "." + EmployeeID;
                //if (Level == "1")
                //{
                //    textBox3.Text = 1 + "." + EmployeeID;
                //}
                //else if (Level == "2")
                //{
                //    textBox3.Text = 2 + "." + EmployeeID;
                //}
                //else if (Level == "3")
                //{
                //    textBox3.Text = 3 + "." + EmployeeID;
                //}
                //else if (Level == "Senior Lecturer")
                //{
                //    textBox3.Text = 4 + "." + EmployeeID;
                //}
                //else if (Level == "Lecturer")
                //{
                //    textBox3.Text = 5 + "." + EmployeeID;
                //}
                //else if (Level == "Assistant Lecturer")
                //{
                //    textBox3.Text = 6 + "." + EmployeeID;
                //}
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {

        }
    }

  
    
}
