namespace TimeManagementSystem
{
    partial class SessionAndNATManagement
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPageNAT = new System.Windows.Forms.TabPage();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateandTime = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSelectSessionID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSelectSubGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSelectGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectLecturer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageNAT.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPageNAT);
            this.tabControl.Location = new System.Drawing.Point(25, 43);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(801, 484);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(793, 456);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Consecutive";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(793, 456);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Parallel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(793, 456);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Not Overlapping";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPageNAT
            // 
            this.tabPageNAT.Controls.Add(this.dtpEndTime);
            this.tabPageNAT.Controls.Add(this.dtpStartTime);
            this.tabPageNAT.Controls.Add(this.label6);
            this.tabPageNAT.Controls.Add(this.label7);
            this.tabPageNAT.Controls.Add(this.dtpDateandTime);
            this.tabPageNAT.Controls.Add(this.btnClear);
            this.tabPageNAT.Controls.Add(this.btnView);
            this.tabPageNAT.Controls.Add(this.btnSubmit);
            this.tabPageNAT.Controls.Add(this.label5);
            this.tabPageNAT.Controls.Add(this.cmbSelectSessionID);
            this.tabPageNAT.Controls.Add(this.label4);
            this.tabPageNAT.Controls.Add(this.cmbSelectSubGroup);
            this.tabPageNAT.Controls.Add(this.label3);
            this.tabPageNAT.Controls.Add(this.cmbSelectGroup);
            this.tabPageNAT.Controls.Add(this.label2);
            this.tabPageNAT.Controls.Add(this.cmbSelectLecturer);
            this.tabPageNAT.Controls.Add(this.label1);
            this.tabPageNAT.Location = new System.Drawing.Point(4, 24);
            this.tabPageNAT.Name = "tabPageNAT";
            this.tabPageNAT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNAT.Size = new System.Drawing.Size(793, 456);
            this.tabPageNAT.TabIndex = 1;
            this.tabPageNAT.Text = "Not Available Time";
            this.tabPageNAT.UseVisualStyleBackColor = true;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(526, 307);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(121, 21);
            this.dtpEndTime.TabIndex = 30;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(346, 307);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(121, 21);
            this.dtpStartTime.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "To:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(287, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "From:";
            // 
            // dtpDateandTime
            // 
            this.dtpDateandTime.Location = new System.Drawing.Point(291, 256);
            this.dtpDateandTime.Name = "dtpDateandTime";
            this.dtpDateandTime.Size = new System.Drawing.Size(356, 21);
            this.dtpDateandTime.TabIndex = 26;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tan;
            this.btnClear.Location = new System.Drawing.Point(542, 374);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 40);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Plum;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(417, 374);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(105, 40);
            this.btnView.TabIndex = 24;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(291, 374);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(105, 40);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Date and Time";
            // 
            // cmbSelectSessionID
            // 
            this.cmbSelectSessionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectSessionID.FormattingEnabled = true;
            this.cmbSelectSessionID.Items.AddRange(new object[] {
            "None"});
            this.cmbSelectSessionID.Location = new System.Drawing.Point(291, 204);
            this.cmbSelectSessionID.Name = "cmbSelectSessionID";
            this.cmbSelectSessionID.Size = new System.Drawing.Size(356, 23);
            this.cmbSelectSessionID.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Select Session ID";
            // 
            // cmbSelectSubGroup
            // 
            this.cmbSelectSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectSubGroup.FormattingEnabled = true;
            this.cmbSelectSubGroup.Location = new System.Drawing.Point(291, 151);
            this.cmbSelectSubGroup.Name = "cmbSelectSubGroup";
            this.cmbSelectSubGroup.Size = new System.Drawing.Size(356, 23);
            this.cmbSelectSubGroup.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select Sub Group";
            // 
            // cmbSelectGroup
            // 
            this.cmbSelectGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectGroup.FormattingEnabled = true;
            this.cmbSelectGroup.Location = new System.Drawing.Point(291, 101);
            this.cmbSelectGroup.Name = "cmbSelectGroup";
            this.cmbSelectGroup.Size = new System.Drawing.Size(356, 23);
            this.cmbSelectGroup.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Group";
            // 
            // cmbSelectLecturer
            // 
            this.cmbSelectLecturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectLecturer.FormattingEnabled = true;
            this.cmbSelectLecturer.Location = new System.Drawing.Point(291, 52);
            this.cmbSelectLecturer.Name = "cmbSelectLecturer";
            this.cmbSelectLecturer.Size = new System.Drawing.Size(356, 23);
            this.cmbSelectLecturer.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Lecturer";
            // 
            // SessionAndNATManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SessionAndNATManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Session and Not Available Time Management";
            this.Load += new System.EventHandler(this.SessionAndNATManagement_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageNAT.ResumeLayout(false);
            this.tabPageNAT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPageNAT;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSelectSessionID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSelectSubGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSelectGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSelectLecturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateandTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

