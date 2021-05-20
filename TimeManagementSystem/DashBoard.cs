using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManagementSystem
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            Lecturer l = new Lecturer();
            l.Show();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            Subject s = new Subject();
            s.Show();
        }

        private void btnSeesion_Click(object sender, EventArgs e)
        {
            Session S = new Session();
            S.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnworking_Click(object sender, EventArgs e)
        {
            WokingDaysHors wd = new WokingDaysHors();
            wd.Show();
                
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            AddStudent std = new AddStudent();
            std.Show();
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            Tags t = new Tags();
            t.Show();
        }
    }
}
