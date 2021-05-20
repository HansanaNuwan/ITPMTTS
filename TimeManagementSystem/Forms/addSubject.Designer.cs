
namespace TimeManagementSystem
{
    partial class Subject
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.cmbOffYear = new System.Windows.Forms.ComboBox();
            this.upLecHours = new System.Windows.Forms.DomainUpDown();
            this.rd1sem = new System.Windows.Forms.RadioButton();
            this.btnMgSubject = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rd2Sem = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.upTuteHours = new System.Windows.Forms.DomainUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.upLabHours = new System.Windows.Forms.DomainUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.upEvaluHours = new System.Windows.Forms.DomainUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(932, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(890, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 34);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD SUBJECT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Offerd Year";
            // 
            // txtSubName
            // 
            this.txtSubName.Location = new System.Drawing.Point(182, 217);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(217, 20);
            this.txtSubName.TabIndex = 2;
            // 
            // cmbOffYear
            // 
            this.cmbOffYear.FormattingEnabled = true;
            this.cmbOffYear.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cmbOffYear.Location = new System.Drawing.Point(182, 120);
            this.cmbOffYear.Name = "cmbOffYear";
            this.cmbOffYear.Size = new System.Drawing.Size(217, 21);
            this.cmbOffYear.TabIndex = 3;
            // 
            // upLecHours
            // 
            this.upLecHours.Items.Add("1");
            this.upLecHours.Items.Add("2");
            this.upLecHours.Items.Add("3");
            this.upLecHours.Items.Add("4");
            this.upLecHours.Items.Add("5");
            this.upLecHours.Items.Add("6");
            this.upLecHours.Items.Add("7");
            this.upLecHours.Items.Add("8");
            this.upLecHours.Items.Add("9");
            this.upLecHours.Items.Add("10");
            this.upLecHours.Location = new System.Drawing.Point(671, 120);
            this.upLecHours.Name = "upLecHours";
            this.upLecHours.Size = new System.Drawing.Size(217, 20);
            this.upLecHours.TabIndex = 4;
            // 
            // rd1sem
            // 
            this.rd1sem.AutoSize = true;
            this.rd1sem.Checked = true;
            this.rd1sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1sem.Location = new System.Drawing.Point(182, 169);
            this.rd1sem.Name = "rd1sem";
            this.rd1sem.Size = new System.Drawing.Size(102, 20);
            this.rd1sem.TabIndex = 5;
            this.rd1sem.TabStop = true;
            this.rd1sem.Text = "1st semester";
            this.rd1sem.UseVisualStyleBackColor = true;
            // 
            // btnMgSubject
            // 
            this.btnMgSubject.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMgSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMgSubject.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMgSubject.ForeColor = System.Drawing.Color.White;
            this.btnMgSubject.Location = new System.Drawing.Point(717, 66);
            this.btnMgSubject.Name = "btnMgSubject";
            this.btnMgSubject.Size = new System.Drawing.Size(155, 34);
            this.btnMgSubject.TabIndex = 6;
            this.btnMgSubject.Text = "Manage Subject";
            this.btnMgSubject.UseVisualStyleBackColor = false;
            this.btnMgSubject.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Offerd Semester";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rd2Sem
            // 
            this.rd2Sem.AutoSize = true;
            this.rd2Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2Sem.Location = new System.Drawing.Point(292, 168);
            this.rd2Sem.Name = "rd2Sem";
            this.rd2Sem.Size = new System.Drawing.Size(107, 20);
            this.rd2Sem.TabIndex = 8;
            this.rd2Sem.Text = "2nd semester";
            this.rd2Sem.UseVisualStyleBackColor = true;
            this.rd2Sem.CheckedChanged += new System.EventHandler(this.rd2Sem_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Subject Code";
            // 
            // txtSubCode
            // 
            this.txtSubCode.Location = new System.Drawing.Point(182, 261);
            this.txtSubCode.Name = "txtSubCode";
            this.txtSubCode.Size = new System.Drawing.Size(217, 20);
            this.txtSubCode.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(457, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "No of Lecture Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(457, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "No of Tutorial Hours";
            // 
            // upTuteHours
            // 
            this.upTuteHours.Items.Add("1");
            this.upTuteHours.Items.Add("2");
            this.upTuteHours.Items.Add("3");
            this.upTuteHours.Items.Add("4");
            this.upTuteHours.Items.Add("5");
            this.upTuteHours.Items.Add("6");
            this.upTuteHours.Items.Add("7");
            this.upTuteHours.Items.Add("8");
            this.upTuteHours.Items.Add("9");
            this.upTuteHours.Items.Add("10");
            this.upTuteHours.Location = new System.Drawing.Point(671, 168);
            this.upTuteHours.Name = "upTuteHours";
            this.upTuteHours.Size = new System.Drawing.Size(217, 20);
            this.upTuteHours.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(457, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "No of Lab Hours";
            // 
            // upLabHours
            // 
            this.upLabHours.Items.Add("1");
            this.upLabHours.Items.Add("2");
            this.upLabHours.Items.Add("3");
            this.upLabHours.Items.Add("4");
            this.upLabHours.Items.Add("5");
            this.upLabHours.Items.Add("6");
            this.upLabHours.Items.Add("7");
            this.upLabHours.Items.Add("8");
            this.upLabHours.Items.Add("9");
            this.upLabHours.Items.Add("10");
            this.upLabHours.Location = new System.Drawing.Point(671, 217);
            this.upLabHours.Name = "upLabHours";
            this.upLabHours.Size = new System.Drawing.Size(217, 20);
            this.upLabHours.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(457, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "No of Evaluation Hours";
            // 
            // upEvaluHours
            // 
            this.upEvaluHours.Items.Add("1");
            this.upEvaluHours.Items.Add("2");
            this.upEvaluHours.Items.Add("3");
            this.upEvaluHours.Items.Add("4");
            this.upEvaluHours.Items.Add("5");
            this.upEvaluHours.Items.Add("6");
            this.upEvaluHours.Items.Add("7");
            this.upEvaluHours.Items.Add("8");
            this.upEvaluHours.Items.Add("9");
            this.upEvaluHours.Items.Add("10");
            this.upEvaluHours.Location = new System.Drawing.Point(671, 261);
            this.upEvaluHours.Name = "upEvaluHours";
            this.upEvaluHours.Size = new System.Drawing.Size(217, 20);
            this.upEvaluHours.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(757, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 34);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(622, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 34);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Subject
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(932, 486);
            this.Controls.Add(this.rd2Sem);
            this.Controls.Add(this.rd1sem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.upEvaluHours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.upLabHours);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.upTuteHours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSubCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMgSubject);
            this.Controls.Add(this.upLecHours);
            this.Controls.Add(this.cmbOffYear);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addSubject";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubName;
        private System.Windows.Forms.ComboBox cmbOffYear;
        private System.Windows.Forms.DomainUpDown upLecHours;
        private System.Windows.Forms.RadioButton rd1sem;
        private System.Windows.Forms.Button btnMgSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rd2Sem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DomainUpDown upTuteHours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown upLabHours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DomainUpDown upEvaluHours;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}