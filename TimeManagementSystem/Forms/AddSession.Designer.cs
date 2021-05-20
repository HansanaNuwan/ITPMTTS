
namespace TimeManagementSystem
{
    partial class Session
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbSelectLec = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSelectLec = new System.Windows.Forms.TextBox();
            this.cmbSelectTag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnNext = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.txtNoStudent = new System.Windows.Forms.TextBox();
            this.cmbSelectSubject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.cmbSelectGroup = new System.Windows.Forms.ComboBox();
            this.BtmgSession = new System.Windows.Forms.Button();
            this.txtSubCode = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(910, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 31);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD SESSION";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(59, 107);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 289);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbSelectLec);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnBack);
            this.tabPage1.Controls.Add(this.txtSelectLec);
            this.tabPage1.Controls.Add(this.cmbSelectTag);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(833, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Lectures & Tags";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.cmbSelectLec.Location = new System.Drawing.Point(223, 79);
            this.cmbSelectLec.Name = "cmbSelectLec";
            this.cmbSelectLec.Size = new System.Drawing.Size(217, 21);
            this.cmbSelectLec.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(223, 36);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(217, 20);
            this.txtID.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "ID";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(567, 186);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 31);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(438, 186);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 31);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSelectLec
            // 
            this.txtSelectLec.Location = new System.Drawing.Point(223, 127);
            this.txtSelectLec.Name = "txtSelectLec";
            this.txtSelectLec.Size = new System.Drawing.Size(338, 20);
            this.txtSelectLec.TabIndex = 6;
            // 
            // cmbSelectTag
            // 
            this.cmbSelectTag.FormattingEnabled = true;
            this.cmbSelectTag.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Practical"});
            this.cmbSelectTag.Location = new System.Drawing.Point(587, 36);
            this.cmbSelectTag.Name = "cmbSelectTag";
            this.cmbSelectTag.Size = new System.Drawing.Size(217, 21);
            this.cmbSelectTag.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selected Lecturer(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Tag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Lecturer(s)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSubCode);
            this.tabPage2.Controls.Add(this.BtnNext);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtDuration);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.btBack);
            this.tabPage2.Controls.Add(this.txtNoStudent);
            this.tabPage2.Controls.Add(this.cmbSelectSubject);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btClear);
            this.tabPage2.Controls.Add(this.cmbSelectGroup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(833, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Select Group & Subject";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.ForeColor = System.Drawing.Color.White;
            this.BtnNext.Location = new System.Drawing.Point(714, 191);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(85, 31);
            this.BtnNext.TabIndex = 22;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Subject Code";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(597, 96);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(217, 20);
            this.txtDuration.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Duration(hrs)";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(464, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 31);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.Location = new System.Drawing.Point(332, 191);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(85, 31);
            this.btBack.TabIndex = 16;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // txtNoStudent
            // 
            this.txtNoStudent.Location = new System.Drawing.Point(597, 41);
            this.txtNoStudent.Name = "txtNoStudent";
            this.txtNoStudent.Size = new System.Drawing.Size(217, 20);
            this.txtNoStudent.TabIndex = 15;
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
            this.cmbSelectSubject.Location = new System.Drawing.Point(191, 96);
            this.cmbSelectSubject.Name = "cmbSelectSubject";
            this.cmbSelectSubject.Size = new System.Drawing.Size(217, 21);
            this.cmbSelectSubject.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Selected Subject";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(448, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "No Of Student";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Select Group";
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.White;
            this.btClear.Location = new System.Drawing.Point(592, 191);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(85, 31);
            this.btClear.TabIndex = 10;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
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
            this.cmbSelectGroup.Location = new System.Drawing.Point(191, 41);
            this.cmbSelectGroup.Name = "cmbSelectGroup";
            this.cmbSelectGroup.Size = new System.Drawing.Size(217, 21);
            this.cmbSelectGroup.TabIndex = 9;
            // 
            // BtmgSession
            // 
            this.BtmgSession.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtmgSession.FlatAppearance.BorderSize = 0;
            this.BtmgSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmgSession.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmgSession.ForeColor = System.Drawing.Color.White;
            this.BtmgSession.Location = new System.Drawing.Point(721, 70);
            this.BtmgSession.Name = "BtmgSession";
            this.BtmgSession.Size = new System.Drawing.Size(156, 31);
            this.BtmgSession.TabIndex = 9;
            this.BtmgSession.Text = "Manage Session";
            this.BtmgSession.UseVisualStyleBackColor = false;
            this.BtmgSession.Click += new System.EventHandler(this.BtmgSession_Click);
            // 
            // txtSubCode
            // 
            this.txtSubCode.FormattingEnabled = true;
            this.txtSubCode.Location = new System.Drawing.Point(191, 146);
            this.txtSubCode.Name = "txtSubCode";
            this.txtSubCode.Size = new System.Drawing.Size(217, 21);
            this.txtSubCode.TabIndex = 23;
            // 
            // Session
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(959, 487);
            this.Controls.Add(this.BtmgSession);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Session";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSession";
            this.Load += new System.EventHandler(this.Session_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSelectLec;
        private System.Windows.Forms.ComboBox cmbSelectTag;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.TextBox txtNoStudent;
        private System.Windows.Forms.ComboBox cmbSelectSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ComboBox cmbSelectGroup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.ComboBox cmbSelectLec;
        private System.Windows.Forms.Button BtmgSession;
        private System.Windows.Forms.ComboBox txtSubCode;
    }
}