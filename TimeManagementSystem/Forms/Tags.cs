using System;
using System.Data;
using System.Windows.Forms;
using TimeManagementSystem.CRUD;

namespace TimeManagementSystem
{
    public partial class Tags : Form
    {
        public Tags()
        {
            InitializeComponent();
        }

        TagsClass c = new TagsClass();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get the value from input fields
            c.TagName = TBTagname.Text;
            c.TagCode = TBTagCode.Text;
            c.RelatedTag = CBRetaledTag.Text;

            //insert data into DB using the created method
            bool success = c.Insert(c);
            if (success == true)
            {
                //successfully inserted
                MessageBox.Show("Tag Inserted !");
                //call the clear method
                Clear();
            }
            else
            {
                //if failed to add
                MessageBox.Show("Failed to add Tag !");
            }

            //Load data to table
            DataTable dt = c.Select();
            dgvTags.DataSource = dt;
        }

        private void Tags_Load(object sender, EventArgs e)
        {
            //Load data to table
            DataTable dt = c.Select();
            dgvTags.DataSource = dt;
        }

        //method to clear input fields
        public void Clear()
        {
            TBtagId.Text = "";
            TBTagname.Text = "";
            TBTagCode.Text = "";
            CBRetaledTag.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the data from text boxes
            c.TagID = int.Parse(TBtagId.Text);
            c.TagName = TBTagname.Text;
            c.TagCode = TBTagCode.Text;
            c.RelatedTag = CBRetaledTag.Text;

            //update data in database
            bool success = c.Update(c);
            if (success == true)
            {
                //success message
                MessageBox.Show("Tag updated !");

                //Load data to table
                DataTable dt = c.Select();
                dgvTags.DataSource = dt;

                //clear textbox
                Clear();
            }
            else
            {
                //if update failed
                MessageBox.Show("Tag update Failed !");
            }
        }

        private void dgvTags_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get and load data into the text boxes
            //mouse clicked row identify
            int rowIndex = e.RowIndex;
            TBtagId.Text = dgvTags.Rows[rowIndex].Cells[0].Value.ToString();
            TBTagname.Text = dgvTags.Rows[rowIndex].Cells[1].Value.ToString();
            TBTagCode.Text = dgvTags.Rows[rowIndex].Cells[2].Value.ToString();
            CBRetaledTag.Text = dgvTags.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void TagID_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //call clear method
            Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //Get Data from textbox
            c.TagID = Convert.ToInt32(TBtagId.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                //if success
                MessageBox.Show("Tag Deleted !");

                //Load data to table
                DataTable dt = c.Select();
                dgvTags.DataSource = dt;

                //clear textbox
                Clear();

            }
            else
            {
                //if failed
                MessageBox.Show("Tag Delete failed !");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageStudent stdm = new ManageStudent();
            stdm.Show();

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
