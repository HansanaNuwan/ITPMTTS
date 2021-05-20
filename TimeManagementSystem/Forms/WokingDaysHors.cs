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
    public partial class WokingDaysHors : Form
    {

        String ID;

        public WokingDaysHors()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            int monday, tuesday, wednessday, thursday, friday, saturday, sunday;

            monday = tuesday = wednessday = thursday = friday = saturday = sunday = 0;

            if (mon_check.Checked)
            {
                monday = 1;
            }

            if (tue_check.Checked)
            {
                tuesday = 1;
            }

            if (wed_check.Checked)
            {
                wednessday = 1;
            }

            if (thu_check.Checked)
            {
                thursday = 1;
            }

            if (fri_check.Checked)
            {
                friday = 1;
            }

            if (sat_check.Checked)
            {
                saturday = 1;
            }

            if (sun_check.Checked)
            {
                sunday = 1;
            }

            SqlConnection con = new SqlConnection(Classes.ConnectionStrings.Database1);
            // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\User\Desktop\Time Table MS\Time Table MS\Database1.mdf;Integrated Security=True");
            con.Open();

            String cmd = "INSERT INTO  [dbo].[WorkingDaysHours](NoOfWorkingDays, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, StartTime, StopTime) " + " VALUES ('" + numericUpDown1.Text + "','" + monday + "','" + tuesday + "','" + wednessday + "','" + thursday + "','" + friday + "','" + saturday + "','" + sunday + "','" + comboBox1.Text + "','" + comboBox2.Text + "')";

            SqlCommand command = new SqlCommand(cmd, con);

            int i = command.ExecuteNonQuery();
            if (i != 0)
            {
                loadData();
                numericUpDown1.ResetText();
                mon_check.Checked = false;
                tue_check.Checked = false;
                wed_check.Checked = false;
                thu_check.Checked = false;
                fri_check.Checked = false;
                sun_check.Checked = false;
                sat_check.Checked = false;
                comboBox1.ResetText();
                comboBox2.ResetText();
                con.Close();

                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("Data not Saved");
                con.Close();
            }
        }

        private void loadData()
        {
            try
            {
                SqlConnection con = new SqlConnection(Classes.ConnectionStrings.Database1);
                //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C: \Users\User\Desktop\Time Table MS\Time Table MS\Database1.mdf; Integrated Security = True");
                con.Open();

                String cmd = "SELECT *  FROM [dbo].[WorkingDaysHours]";
                SqlCommand command = new SqlCommand(cmd, con);

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                SqlDataAdapter dAdapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                dAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WokingDaysHors_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    ID = row.Cells[0].Value.ToString();

                    numericUpDown1.Text = row.Cells[1].Value.ToString();

                    int monday = Int32.Parse(row.Cells[2].Value.ToString());
                    int tuesday = Int32.Parse(row.Cells[3].Value.ToString());
                    int wednesday = Int32.Parse(row.Cells[4].Value.ToString());
                    int thursday = Int32.Parse(row.Cells[5].Value.ToString());
                    int friday = Int32.Parse(row.Cells[6].Value.ToString());
                    int saturday = Int32.Parse(row.Cells[7].Value.ToString());
                    int sunday = Int32.Parse(row.Cells[8].Value.ToString());

                    if (monday == 1)
                    {
                        mon_check.Checked = true;
                    }
                    else
                    {
                        mon_check.Checked = false;
                    }

                    if (tuesday == 1)
                    {
                        tue_check.Checked = true;
                    }
                    else
                    {
                        tue_check.Checked = false;
                    }

                    if (wednesday == 1)
                    {
                        wed_check.Checked = true;
                    }
                    else
                    {
                        wed_check.Checked = false;
                    }

                    if (thursday == 1)
                    {
                        thu_check.Checked = true;
                    }
                    else
                    {
                        thu_check.Checked = false;
                    }

                    if (friday == 1)
                    {
                        fri_check.Checked = true;
                    }
                    else
                    {
                        fri_check.Checked = false;
                    }

                    if (saturday == 1)
                    {
                        sat_check.Checked = true;
                    }
                    else
                    {
                        sat_check.Checked = false;
                    }

                    if (sunday == 1)
                    {
                        sun_check.Checked = true;
                    }
                    else
                    {
                        sun_check.Checked = false;
                    }

                    comboBox1.Text = row.Cells[9].Value.ToString();
                    comboBox2.Text = row.Cells[10].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int monday, tuesday, wednessday, thursday, friday, saturday, sunday;

            monday = tuesday = wednessday = thursday = friday = saturday = sunday = 0;

            if (mon_check.Checked)
            {
                monday = 1;
            }

            if (tue_check.Checked)
            {
                tuesday = 1;
            }

            if (wed_check.Checked)
            {
                wednessday = 1;
            }

            if (thu_check.Checked)
            {
                thursday = 1;
            }

            if (fri_check.Checked)
            {
                friday = 1;
            }

            if (sat_check.Checked)
            {
                saturday = 1;
            }

            if (sun_check.Checked)
            {
                sunday = 1;
            }

            SqlConnection con = new SqlConnection(Classes.ConnectionStrings.Database1);
            // SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C: \Users\User\Desktop\Time Table MS\Time Table MS\Database1.mdf; Integrated Security = True");
            con.Open();

            String cmd = "UPDATE [dbo].[WorkingDaysHours] SET  NoOfWorkingDays='" + numericUpDown1.Text + "', Monday='" + monday + "', Tuesday='" + tuesday + "', Wednesday='" + wednessday + "',Thursday='" + thursday + "',Friday='" + friday + "' ,Saturday='" + saturday + "',Sunday='" + sunday + "' ,StartTime='" + comboBox1.Text + "' ,StopTime='" + comboBox2.Text + "' WHERE Id='" + ID + "';";


            SqlCommand command = new SqlCommand(cmd, con);

            int i = command.ExecuteNonQuery();
            if (i != 0)
            {
                loadData();
                numericUpDown1.ResetText();
                mon_check.Checked = false;
                tue_check.Checked = false;
                wed_check.Checked = false;
                thu_check.Checked = false;
                fri_check.Checked = false;
                sun_check.Checked = false;
                sat_check.Checked = false;
                comboBox1.ResetText();
                comboBox2.ResetText();
                con.Close();

                MessageBox.Show("Data Updated");
            }
            else
            {
                MessageBox.Show("Data not Updated");
                con.Close();
            }
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure to delete this student Group ??", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(Classes.ConnectionStrings.Database1);
                //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C: \Users\User\Desktop\Time Table MS\Time Table MS\Database1.mdf; Integrated Security = True");
                con.Open();

                String cmd = "DELETE  FROM [dbo].[WorkingDaysHours] WHERE Id='" + ID + "';";

                SqlCommand command = new SqlCommand(cmd, con);

                int i = command.ExecuteNonQuery();
                if (i != 0)
                {
                    loadData();
                    numericUpDown1.ResetText();
                    mon_check.Checked = false;
                    tue_check.Checked = false;
                    wed_check.Checked = false;
                    thu_check.Checked = false;
                    fri_check.Checked = false;
                    sun_check.Checked = false;
                    sat_check.Checked = false;
                    comboBox1.ResetText();
                    comboBox2.ResetText();
                    con.Close();

                    MessageBox.Show("Data Deleted");
                }
                else
                {
                    MessageBox.Show("Data not Deleted");
                    con.Close();
                }
            }

        }

    }
}
