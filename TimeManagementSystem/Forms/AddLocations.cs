using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TimeManagementSystem
{
    public partial class AddLocations : Form
    {
        public AddLocations()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if(txtBuildingName.Text == "" || txtRoomName.Text=="" || txtCapacity.Text == "")
                {
                    MessageBox.Show("Please insert all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string roomType;

                    if (rbtLectureHall.Checked)
                    {
                        roomType = "Lecture Hall";
                    }
                    else
                    {
                        roomType = "Laboratory";
                    }

                    SqlConnection connection = new SqlConnection(Classes.ConnectionStrings.ABCInstituteDB);

                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO  dbo.[Location](Building, Room, Room_Type, Capacity) " + " VALUES ('" + txtBuildingName.Text + "','" + txtRoomName.Text + "','" + roomType + "','" + txtCapacity.Text + "')", connection);
                   
                    int i = command.ExecuteNonQuery();
                    
                    if (i != 0 )
                    {
                        clear();
                        connection.Close();
                        MessageBox.Show("Data Saved");
                        ManageLocations frm2 = new ManageLocations();
                        frm2.Show();
                        this.Hide();
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Data not Saved", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void clear()
        {
            txtBuildingName.ResetText();
            txtRoomName.ResetText();
            txtCapacity.ResetText();
            rbtLectureHall.Checked = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            try
            {

                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ManageLocations M = new ManageLocations();
            M.Show();
        }
    }
}
