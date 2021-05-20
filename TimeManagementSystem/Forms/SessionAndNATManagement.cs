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
    public partial class SessionAndNATManagement : Form
    {
        SqlConnection connection;

        public SessionAndNATManagement()
        {
            InitializeComponent();

            connection = new SqlConnection(
                Classes.ConnectionStrings.ABCDatabase);

            dtpDateandTime.MinDate = DateTime.Now;

            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            dtpEndTime.CustomFormat = "hh:mm tt";
            dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        }

        public void loadAllDatafromDB()
        {
            try
            {
                loadLecturersData();
                loadGroupData();
                loadSubGroupData();
                loadSessionsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadLecturersData()
        {
            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Name FROM Lecturer", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataTable.Rows.Add("None");
                cmbSelectLecturer.DataSource = dataTable;
                cmbSelectLecturer.DisplayMember = "Name";
                cmbSelectLecturer.ValueMember = "Name";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadGroupData()
        {
            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Group_ID FROM dbo.[Group]", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                cmbSelectGroup.DataSource = dataTable;
                cmbSelectGroup.DisplayMember = "Group_ID";
                cmbSelectGroup.ValueMember = "Group_ID";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadSubGroupData()
        {
            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Sub_Group_ID FROM dbo.[Group]", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                cmbSelectSubGroup.DataSource = dataTable;
                cmbSelectSubGroup.DisplayMember = "Sub_Group_ID";
                cmbSelectSubGroup.ValueMember = "Sub_Group_ID";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadSessionsData()
        {
            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT ID FROM Session", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable); 
                dataTable.Rows.Add(00);
                cmbSelectSessionID.DataSource = dataTable;
                cmbSelectSessionID.DisplayMember = "ID";
                cmbSelectSessionID.ValueMember = "ID";

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            try
            {
                loadAllDatafromDB();
                dtpDateandTime.ResetText();
                dtpStartTime.ResetText();
                dtpEndTime.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSelectLecturer.SelectedItem == null)
                {
                    MessageBox.Show("No Lecturers in the System.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbSelectGroup.SelectedItem == null)
                {
                    MessageBox.Show("No Groups in the System.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbSelectSubGroup.SelectedItem == null)
                {
                    MessageBox.Show("No Groups in the System.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbSelectSessionID.SelectedItem == null)
                {
                    MessageBox.Show("No Sessions in the System.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dtpDateandTime.Text == "")
                {
                    MessageBox.Show("Please enter Date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dtpStartTime.Text == dtpEndTime.Text)
                {
                    MessageBox.Show("Please enter valid Time.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    string dateAndTime = dtpDateandTime.Text + " - ( " + dtpStartTime.Text + " - " + dtpEndTime.Text + " )";

                    string sessionID;

                    if(cmbSelectSessionID.Text == "0")
                    {
                        sessionID = "None";
                    }
                    else
                    {
                        sessionID = cmbSelectSessionID.Text;
                    }

                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO  dbo.[NotAvailableTime] (Duration, Lecturer, Group_ID, Sub_Group_ID, Session_ID) " + " VALUES ('" + dateAndTime + "','" + cmbSelectLecturer.Text + "','" + cmbSelectGroup.Text + "','" + cmbSelectSubGroup.Text + "','" + sessionID + "')", connection);

                    int x = command.ExecuteNonQuery();

                    if (x != 0)
                    {
                        connection.Close();
                        clear();
                        MessageBox.Show("Adding Successful.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Adding Failed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                ManageNotAvailableTimes form = new ManageNotAvailableTimes();
                this.Hide();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedIndex == 0)
                {
                    //load consecutive data.
                }
                if (tabControl.SelectedIndex == 1)
                {
                    //load parallel data.
                }
                if (tabControl.SelectedIndex == 2)
                {
                    //load not over lapping data.
                }
                if (tabControl.SelectedIndex == 3)
                {

                    loadAllDatafromDB();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SessionAndNATManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
