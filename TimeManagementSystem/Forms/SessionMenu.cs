using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManagementSystem.Forms
{
    public partial class SessionMenu : Form
    {
        public SessionMenu()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            Session S = new Session();
            S.Show();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            SessionList SL = new SessionList();
            SL.Show();
        }

        private void SessionMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
