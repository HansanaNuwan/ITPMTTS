
namespace TimeManagementSystem
{
    partial class AddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.NMSubGroupNo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NMGroupNo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.CBProgramme = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBYearSem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSGroupID = new System.Windows.Forms.TextBox();
            this.lblGroupID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMSubGroupNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMGroupNo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 61);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD STUDENT GROUPS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Sub Group ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Group ID";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerate.Location = new System.Drawing.Point(441, 226);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 32);
            this.btnGenerate.TabIndex = 33;
            this.btnGenerate.Text = "Generate ID";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(441, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // NMSubGroupNo
            // 
            this.NMSubGroupNo.Location = new System.Drawing.Point(200, 277);
            this.NMSubGroupNo.Name = "NMSubGroupNo";
            this.NMSubGroupNo.Size = new System.Drawing.Size(120, 20);
            this.NMSubGroupNo.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "SubGroup No";
            // 
            // NMGroupNo
            // 
            this.NMGroupNo.Location = new System.Drawing.Point(200, 230);
            this.NMGroupNo.Name = "NMGroupNo";
            this.NMGroupNo.Size = new System.Drawing.Size(120, 20);
            this.NMGroupNo.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Group No";
            // 
            // CBProgramme
            // 
            this.CBProgramme.FormattingEnabled = true;
            this.CBProgramme.Items.AddRange(new object[] {
            "IT",
            "CSSE",
            "CSE",
            "IM"});
            this.CBProgramme.Location = new System.Drawing.Point(200, 184);
            this.CBProgramme.Name = "CBProgramme";
            this.CBProgramme.Size = new System.Drawing.Size(121, 21);
            this.CBProgramme.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Programme";
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
            this.CBYearSem.Location = new System.Drawing.Point(200, 144);
            this.CBYearSem.Name = "CBYearSem";
            this.CBYearSem.Size = new System.Drawing.Size(121, 21);
            this.CBYearSem.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Academic Year /Semester";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(441, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(441, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "view";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSGroupID
            // 
            this.lblSGroupID.Location = new System.Drawing.Point(487, 180);
            this.lblSGroupID.Name = "lblSGroupID";
            this.lblSGroupID.ReadOnly = true;
            this.lblSGroupID.Size = new System.Drawing.Size(100, 20);
            this.lblSGroupID.TabIndex = 41;
            // 
            // lblGroupID
            // 
            this.lblGroupID.Location = new System.Drawing.Point(487, 141);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.ReadOnly = true;
            this.lblGroupID.Size = new System.Drawing.Size(100, 20);
            this.lblGroupID.TabIndex = 40;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSGroupID);
            this.Controls.Add(this.lblGroupID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.NMSubGroupNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NMGroupNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBProgramme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBYearSem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMSubGroupNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMGroupNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown NMSubGroupNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NMGroupNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBProgramme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBYearSem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lblSGroupID;
        private System.Windows.Forms.TextBox lblGroupID;
    }
}