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
    public partial class Visualize : Form
    {
        SQLiteConnection connection;

        public Visualize()
        {
            InitializeComponent();

            connection = new Classes.SqliteHelper().GetSQLiteConnection();
        }

        private void Visualize_Load(object sender, EventArgs e)
        {

            try
            {
                registeredCounts();

                whatsNew();

                loadChart();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        public void registeredCounts()
        {
            try
            {
                SQLiteCommand command1 = new SQLiteCommand("SELECT COUNT(*) FROM [Lecturer] ;", connection);
                SQLiteCommand command2 = new SQLiteCommand("SELECT SUM (Student_Count) FROM [Session] ;", connection);
                SQLiteCommand command3 = new SQLiteCommand("SELECT COUNT(*) FROM [Subject] ;", connection);
                SQLiteCommand command4 = new SQLiteCommand("SELECT COUNT(*) FROM [Location] ;", connection);
                connection.Open();
                int countLectures = Convert.ToInt32(command1.ExecuteScalar());
                int countStudents = Convert.ToInt32(command2.ExecuteScalar());
                int countSubjects = Convert.ToInt32(command3.ExecuteScalar());
                int countRooms = Convert.ToInt32(command4.ExecuteScalar());

                btnRegLectures.Text = countLectures.ToString();
                btnRegStudents.Text = countStudents.ToString();
                btnRegSubjects.Text = countSubjects.ToString();
                btnRegRooms.Text = countRooms.ToString();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void whatsNew()
        {
            try
            {
                SQLiteCommand command1 = new SQLiteCommand("SELECT TOP(1) Name FROM [Lecturer] ORDER BY ID DESC ;", connection);
                SQLiteCommand command2 = new SQLiteCommand("SELECT TOP(1) Name FROM [Group] ORDER BY ID DESC ;", connection);
                SQLiteCommand command3 = new SQLiteCommand("SELECT TOP(1) Name FROM [Subject] ORDER BY ID DESC ;", connection);
                connection.Open();
                string latestLectures = command1.ExecuteScalar().ToString();
                string latestGroup = command2.ExecuteScalar().ToString();
                string latestSubjects = command3.ExecuteScalar().ToString();

                txtLatestLecturer.Text = latestLectures;
                txtLatestGroup.Text = latestGroup;
                txtLatestSubject.Text = latestSubjects;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadChart()
        {

            try
            {
                SQLiteCommand command1 = new SQLiteCommand("SELECT COUNT(*) AS Counts, Room_Type FROM Location GROUP BY Room_Type;", connection);
                connection.Open();

                SQLiteDataReader read = command1.ExecuteReader();

                while (read.Read())
                {
                    chrtLocations.Series[read["Room_Type"].ToString()].Points.AddXY("Locations", Convert.ToInt32(read["Counts"]));
                }
                read.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegLectures_Click(object sender, EventArgs e)
        {
            try
            {
                Statics frm1 = new Statics();
                frm1.type = 1;
                frm1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegStudents_Click(object sender, EventArgs e)
        {
            try
            {
                Statics frm2 = new Statics();
                frm2.type = 2;
                frm2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegSubjects_Click(object sender, EventArgs e)
        {
            try
            {
                Statics frm3 = new Statics();
                frm3.type = 3;
                frm3.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageSessionRooms frm1 = new ManageSessionRooms();
            frm1.Show();
            this.Hide();
        }
    }
}
