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
    }
}
