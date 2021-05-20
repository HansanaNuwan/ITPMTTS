
namespace TimeManagementSystem
{
    partial class manageSession
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.txtSelectLec = new System.Windows.Forms.TextBox();
            this.cmbSelectTag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectLec = new System.Windows.Forms.ComboBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoStudent = new System.Windows.Forms.TextBox();
            this.cmbSelectSubject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSelectGroup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(910, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 31);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE SESSION";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(592, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(314, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 200);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(409, 519);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 31);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(529, 519);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 31);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(649, 519);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 31);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(770, 519);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 31);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddSession
            // 
            this.btnAddSession.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddSession.FlatAppearance.BorderSize = 0;
            this.btnAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSession.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSession.ForeColor = System.Drawing.Color.White;
            this.btnAddSession.Location = new System.Drawing.Point(802, 66);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(120, 31);
            this.btnAddSession.TabIndex = 8;
            this.btnAddSession.Text = "Add Session";
            this.btnAddSession.UseVisualStyleBackColor = false;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // txtSelectLec
            // 
            this.txtSelectLec.Location = new System.Drawing.Point(229, 400);
            this.txtSelectLec.Name = "txtSelectLec";
            this.txtSelectLec.Size = new System.Drawing.Size(217, 20);
            this.txtSelectLec.TabIndex = 14;
            // 
            // cmbSelectTag
            // 
            this.cmbSelectTag.FormattingEnabled = true;
            this.cmbSelectTag.Items.AddRange(new object[] {
            "Lecture",
            "Practical",
            "Tutorial"});
            this.cmbSelectTag.Location = new System.Drawing.Point(695, 399);
            this.cmbSelectTag.Name = "cmbSelectTag";
            this.cmbSelectTag.Size = new System.Drawing.Size(217, 21);
            this.cmbSelectTag.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Selected Lecturer(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select Tag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Lecturer(s)";
            // 
            // cmbSelectLec
            // 
            this.cmbSelectLec.FormattingEnabled = true;
            this.cmbSelectLec.Items.AddRange(new object[] {
            "Mr. Lasitha Petthawadu",
            "Mr.Dilshan De Silva ",
            "Ms.Archchana Kugathasan",
            "Ms.Hansi Mayadunna ",
            "Ms.Rashmi Shamindra",
            "Ms. Thamali Dassanayake",
            "Ms. Nadeesa Pemadasa",
            "Ms.Shashika Lokuliyana",
            "Ms. Sasini Wellalalage",
            "Mr. Nalaka R. Dissanayake",
            "Mr. Nelum Chathura Amarasena",
            "Mrs. Amali Gunasinghe",
            "Mrs. Vijani Piyawardana",
            "Ms. Lumini Wickramasinghe",
            "Mr. Pubudu Nallaperuma",
            "Ms. Baanujah Jeevanathan"});
            this.cmbSelectLec.Location = new System.Drawing.Point(229, 359);
            this.cmbSelectLec.Name = "cmbSelectLec";
            this.cmbSelectLec.Size = new System.Drawing.Size(217, 21);
            this.cmbSelectLec.TabIndex = 9;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(695, 475);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(217, 20);
            this.txtDuration.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(526, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Duration(hrs)";
            // 
            // txtNoStudent
            // 
            this.txtNoStudent.Location = new System.Drawing.Point(695, 437);
            this.txtNoStudent.Name = "txtNoStudent";
            this.txtNoStudent.Size = new System.Drawing.Size(217, 20);
            this.txtNoStudent.TabIndex = 25;
            // 
            // cmbSelectSubject
            // 
            this.cmbSelectSubject.FormattingEnabled = true;
            this.cmbSelectSubject.Items.AddRange(new object[] {
            "CN",
            "DSA",
            "DMS",
            "DS",
            "ESD",
            "EAP",
            "IP",
            "ITP",
            "ITPM",
            "MAD",
            "NDM",
            "OOP",
            "OSSA",
            "PS",
            "PAF",
            "SE"});
            this.cmbSelectSubject.Location = new System.Drawing.Point(229, 481);
            this.cmbSelectSubject.Name = "cmbSelectSubject";
            this.cmbSelectSubject.Size = new System.Drawing.Size(217, 21);
            this.cmbSelectSubject.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Selected Subject";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(526, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "No Of Student";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(526, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Select Group";
            // 
            // cmbSelectGroup
            // 
            this.cmbSelectGroup.FormattingEnabled = true;
            this.cmbSelectGroup.Items.AddRange(new object[] {
            "Y1S1.17(Foreign IT)",
            "Y1S1.18(Foreign SE)",
            "Y1S1.19(Foreign CSNE)",
            "Y1S1.02(IT)",
            "Y1S1.03(IT)",
            "Y1S1.04(IT)",
            "Y1S1.05(IT)",
            "Y1S1.06(IT)",
            "Y1S1.07(IT)",
            "Y1S1.08(IT)",
            "Y1S1.09(IT)",
            "Y1S1.10(IT)",
            "Y1S1.11(IT)",
            "Y1S1.12(IT)",
            "Y1S1.13(IT)",
            "Y1S1.14(IT)",
            "Y1S1.15(IT)",
            "Y1S1.16(IT)",
            "Y1S2.01(IT)",
            "Y1S2.02(IT)",
            "Y1S2.03(IT)",
            "Y1S2.04(IT)",
            "Y1S2.05(IT)",
            "Y2S1.04(IT)",
            "Y2S1.05(IT)",
            "Y2S1.06(IT)",
            "Y2S1.07(IT)",
            "Y2S1.08(IT)",
            "Y2S1.09(IT)",
            "Y2S1.10(IT)",
            "Y2S1.11(IT)",
            "Y2S1.12(IT)",
            "Y2S1.13(IT)",
            "Y2S1.14(IT)",
            "Y2S1.15(CSNE)",
            "Y2S1.16(IS)",
            "Y2S1.17(CS)",
            "Y2S1.18(Foreign-IT/SE)",
            "Y2S1.19(Foreign-CSNE)",
            "Y2S1.21(CS)",
            "Y2S2.01(IT)",
            "Y2S2.02(IT)",
            "Y2S2.03(IT)",
            "Y2S2.04(CSNE)",
            "Y2S2.05(IS)",
            "Y2S2.06(CS)",
            "Y3S1.12(IT)",
            "Y3S1.13(IT)",
            "Y3S1.14(IT)",
            "Y3S1.15(DS)",
            "Y3S1.16(SE)",
            "Y3S1.17(CSNE)",
            "Y3S1.18(CSNE)",
            "Y3S1.19(ISE)",
            "Y3S1.20(CS)",
            "Y3S1.21(Curtin-IT/SE)",
            "Y3S1.22(Curtin-CSNE)",
            "Y3S2.05(IT)",
            "Y3S2.06(SE)",
            "Y3S2.07(CSNE)",
            "Y3S2.08(ISE)",
            "Y3S2.09(CS)",
            "Y3S2.10(DS)",
            "Y4S1.08(IT)",
            "Y4S1.09(DS)",
            "Y4S1.10(SE)",
            "Y4S1.11(CSNE)",
            "Y4S1.12(IS)",
            "Y4S1.13(CS)",
            "Y4S2.08(IT)",
            "Y4S2.09(DS)",
            "Y4S2.10(SE)",
            "Y4S2.11(CSNE)",
            "Y4S2.12(IS)",
            "Y4S2.13(CS)"});
            this.cmbSelectGroup.Location = new System.Drawing.Point(695, 359);
            this.cmbSelectGroup.Name = "cmbSelectGroup";
            this.cmbSelectGroup.Size = new System.Drawing.Size(217, 21);
            this.cmbSelectGroup.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Subject Code";
            // 
            // txtSubCode
            // 
            this.txtSubCode.Location = new System.Drawing.Point(229, 441);
            this.txtSubCode.Name = "txtSubCode";
            this.txtSubCode.Size = new System.Drawing.Size(217, 20);
            this.txtSubCode.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(229, 321);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(217, 20);
            this.txtID.TabIndex = 31;
            // 
            // manageSession
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(959, 572);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSubCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNoStudent);
            this.Controls.Add(this.cmbSelectSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSelectGroup);
            this.Controls.Add(this.txtSelectLec);
            this.Controls.Add(this.cmbSelectTag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSelectLec);
            this.Controls.Add(this.btnAddSession);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manageSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manageSession";
            this.Load += new System.EventHandler(this.manageSession_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.TextBox txtSelectLec;
        private System.Windows.Forms.ComboBox cmbSelectTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSelectLec;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoStudent;
        private System.Windows.Forms.ComboBox cmbSelectSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSelectGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubCode;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtID;
    }
}