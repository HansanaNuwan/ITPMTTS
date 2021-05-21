using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TimeManagementSystem
{
    public partial class ManageNotAvailableTimes : Form
    {
        SQLiteConnection connection;
        private string id = "0"; 

        public ManageNotAvailableTimes()
        {
            InitializeComponent();

            connection = new Classes.SqliteHelper().GetSQLiteConnection();

        }

        private void ManageNotAvailableTimes_Load(object sender, EventArgs e)
        {
            try
            {
                loadNATData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadNATData()
        {
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT *  FROM [NotAvailableTime] ;", connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                dgvResultNAT.DataSource = null;
                dgvResultNAT.Rows.Clear();

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dgvResultNAT.AutoGenerateColumns = false;
                    dgvResultNAT.ColumnCount = 6;

                    dgvResultNAT.Columns[0].HeaderText = "ID";
                    dgvResultNAT.Columns[0].DataPropertyName = "ID";

                    dgvResultNAT.Columns[1].HeaderText = "Duration";
                    dgvResultNAT.Columns[1].DataPropertyName = "Duration";

                    dgvResultNAT.Columns[2].HeaderText = "Lecturer";
                    dgvResultNAT.Columns[2].DataPropertyName = "Lecturer";

                    dgvResultNAT.Columns[3].HeaderText = "Group ID";
                    dgvResultNAT.Columns[3].DataPropertyName = "Group_ID";

                    dgvResultNAT.Columns[4].HeaderText = "Sub Group ID";
                    dgvResultNAT.Columns[4].DataPropertyName = "Sub_Group_ID";

                    dgvResultNAT.Columns[5].HeaderText = "Session ID";
                    dgvResultNAT.Columns[5].DataPropertyName = "Session_ID";

                    dgvResultNAT.DataSource = dataTable;
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("No Data in the System.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                SessionAndNATManagement form = new SessionAndNATManagement();
                this.Hide();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                loadNATData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvResultNAT_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvResultNAT.Rows[e.RowIndex];
                    id = row.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(id == "0")
                {
                    MessageBox.Show("Please select a session.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("DELETE FROM [NotAvailableTime]  WHERE ID='" + id + "';", connection);

                    int x = command.ExecuteNonQuery();

                    if (x != 0)
                    {
                        connection.Close();
                        MessageBox.Show("Data Deleted", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Data Not Deleted", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLocations form = new AddLocations();
            this.Hide();
            form.Show();
        }
    }
}
