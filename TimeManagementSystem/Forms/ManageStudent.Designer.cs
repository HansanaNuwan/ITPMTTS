
namespace TimeManagementSystem
{
    partial class ManageStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CBYearSem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBProgramme = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NMGroupNo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NMSubGroupNo = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgvManageStudent = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.TBID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGroupID = new System.Windows.Forms.TextBox();
            this.lblSGroupID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMGroupNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMSubGroupNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE STUDENT GROUPS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 64);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Academic Year /Semester";
            // 
            // CBYearSem
            // 
            this.CBYearSem.FormattingEnabled = true;
            this.CBYearSem.Items.AddRange(new object[] {
            "Y1.S1",
            "Y1.S2",
            "Y2.S1",
            "Y2.S2",
            "Y3.S1",
            "Y3.S2",
            "Y4.S1",
            "Y4.S2"});
            this.CBYearSem.Location = new System.Drawing.Point(307, 332);
            this.CBYearSem.Name = "CBYearSem";
            this.CBYearSem.Size = new System.Drawing.Size(121, 21);
            this.CBYearSem.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Programme";
            // 
            // CBProgramme
            // 
            this.CBProgramme.FormattingEnabled = true;
            this.CBProgramme.Items.AddRange(new object[] {
            "IT",
            "CSSE",
            "CSE",
            "IM"});
            this.CBProgramme.Location = new System.Drawing.Point(307, 372);
            this.CBProgramme.Name = "CBProgramme";
            this.CBProgramme.Size = new System.Drawing.Size(121, 21);
            this.CBProgramme.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Group No";
            // 
            // NMGroupNo
            // 
            this.NMGroupNo.Location = new System.Drawing.Point(307, 418);
            this.NMGroupNo.Name = "NMGroupNo";
            this.NMGroupNo.Size = new System.Drawing.Size(120, 20);
            this.NMGroupNo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SubGroup No";
            // 
            // NMSubGroupNo
            // 
            this.NMSubGroupNo.Location = new System.Drawing.Point(307, 465);
            this.NMSubGroupNo.Name = "NMSubGroupNo";
            this.NMSubGroupNo.Size = new System.Drawing.Size(120, 20);
            this.NMSubGroupNo.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(260, 509);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerate.Location = new System.Drawing.Point(541, 415);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(86, 33);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate ID";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgvManageStudent
            // 
            this.dgvManageStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageStudent.Location = new System.Drawing.Point(41, 84);
            this.dgvManageStudent.Name = "dgvManageStudent";
            this.dgvManageStudent.Size = new System.Drawing.Size(736, 201);
            this.dgvManageStudent.TabIndex = 17;
            this.dgvManageStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageStudent_CellContentClick);
            this.dgvManageStudent.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvManageStudent_RowHeaderMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID";
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(307, 299);
            this.TBID.Name = "TBID";
            this.TBID.ReadOnly = true;
            this.TBID.Size = new System.Drawing.Size(120, 20);
            this.TBID.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.Location = new System.Drawing.Point(446, 509);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(541, 509);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Group ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Sub Group ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(353, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGroupID
            // 
            this.lblGroupID.Location = new System.Drawing.Point(597, 329);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Size = new System.Drawing.Size(100, 20);
            this.lblGroupID.TabIndex = 25;
            // 
            // lblSGroupID
            // 
            this.lblSGroupID.Location = new System.Drawing.Point(597, 368);
            this.lblSGroupID.Name = "lblSGroupID";
            this.lblSGroupID.Size = new System.Drawing.Size(100, 20);
            this.lblSGroupID.TabIndex = 26;
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 565);
            this.Controls.Add(this.lblSGroupID);
            this.Controls.Add(this.lblGroupID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.TBID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvManageStudent);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.NMSubGroupNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NMGroupNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBProgramme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBYearSem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageStudent";
            this.Text = "StudentManage";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMGroupNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMSubGroupNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBYearSem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBProgramme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NMGroupNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NMSubGroupNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgvManageStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lblGroupID;
        private System.Windows.Forms.TextBox lblSGroupID;
    }
}