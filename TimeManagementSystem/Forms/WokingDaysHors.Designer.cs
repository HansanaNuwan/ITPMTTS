namespace TimeManagementSystem
{
    partial class WokingDaysHors
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sun_check = new System.Windows.Forms.CheckBox();
            this.sat_check = new System.Windows.Forms.CheckBox();
            this.fri_check = new System.Windows.Forms.CheckBox();
            this.thu_check = new System.Windows.Forms.CheckBox();
            this.wed_check = new System.Windows.Forms.CheckBox();
            this.tue_check = new System.Windows.Forms.CheckBox();
            this.mon_check = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Delete.Location = new System.Drawing.Point(738, 484);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(145, 47);
            this.btn_Delete.TabIndex = 56;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Update.Location = new System.Drawing.Point(571, 484);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(139, 47);
            this.btn_Update.TabIndex = 55;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Add.Location = new System.Drawing.Point(400, 484);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(144, 47);
            this.btn_Add.TabIndex = 54;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(923, 349);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(174, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "To";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "08.30",
            "09.30",
            "10.30",
            "11.30",
            "12.30",
            "13.30",
            "14.30",
            "15.30",
            "16.30",
            "17.30",
            "18.30",
            "19.30",
            "20.30"});
            this.comboBox2.Location = new System.Drawing.Point(213, 528);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 24);
            this.comboBox2.TabIndex = 51;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "08.30",
            "09.30",
            "10.30",
            "11.30",
            "12.30",
            "13.30",
            "14.30",
            "15.30",
            "16.30",
            "17.30",
            "18.30",
            "19.30",
            "20.30"});
            this.comboBox1.Location = new System.Drawing.Point(22, 524);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 24);
            this.comboBox1.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Time Slot";
            // 
            // sun_check
            // 
            this.sun_check.AutoSize = true;
            this.sun_check.Location = new System.Drawing.Point(34, 412);
            this.sun_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sun_check.Name = "sun_check";
            this.sun_check.Size = new System.Drawing.Size(78, 21);
            this.sun_check.TabIndex = 48;
            this.sun_check.Text = "Sunday";
            this.sun_check.UseVisualStyleBackColor = true;
            // 
            // sat_check
            // 
            this.sat_check.AutoSize = true;
            this.sat_check.Location = new System.Drawing.Point(34, 377);
            this.sat_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sat_check.Name = "sat_check";
            this.sat_check.Size = new System.Drawing.Size(87, 21);
            this.sat_check.TabIndex = 47;
            this.sat_check.Text = "Saturday";
            this.sat_check.UseVisualStyleBackColor = true;
            // 
            // fri_check
            // 
            this.fri_check.AutoSize = true;
            this.fri_check.Location = new System.Drawing.Point(34, 344);
            this.fri_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fri_check.Name = "fri_check";
            this.fri_check.Size = new System.Drawing.Size(69, 21);
            this.fri_check.TabIndex = 46;
            this.fri_check.Text = "Friday";
            this.fri_check.UseVisualStyleBackColor = true;
            // 
            // thu_check
            // 
            this.thu_check.AutoSize = true;
            this.thu_check.Location = new System.Drawing.Point(34, 310);
            this.thu_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thu_check.Name = "thu_check";
            this.thu_check.Size = new System.Drawing.Size(90, 21);
            this.thu_check.TabIndex = 45;
            this.thu_check.Text = "Thursday";
            this.thu_check.UseVisualStyleBackColor = true;
            // 
            // wed_check
            // 
            this.wed_check.AutoSize = true;
            this.wed_check.Location = new System.Drawing.Point(34, 276);
            this.wed_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wed_check.Name = "wed_check";
            this.wed_check.Size = new System.Drawing.Size(105, 21);
            this.wed_check.TabIndex = 44;
            this.wed_check.Text = "Wednesday";
            this.wed_check.UseVisualStyleBackColor = true;
            // 
            // tue_check
            // 
            this.tue_check.AutoSize = true;
            this.tue_check.Location = new System.Drawing.Point(34, 243);
            this.tue_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tue_check.Name = "tue_check";
            this.tue_check.Size = new System.Drawing.Size(85, 21);
            this.tue_check.TabIndex = 43;
            this.tue_check.Text = "Tuesday";
            this.tue_check.UseVisualStyleBackColor = true;
            // 
            // mon_check
            // 
            this.mon_check.AutoSize = true;
            this.mon_check.Location = new System.Drawing.Point(34, 209);
            this.mon_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mon_check.Name = "mon_check";
            this.mon_check.Size = new System.Drawing.Size(80, 21);
            this.mon_check.TabIndex = 42;
            this.mon_check.Text = "Monday";
            this.mon_check.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Working Days";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(34, 137);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(229, 22);
            this.numericUpDown1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Number Of Working Days And Hours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(517, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Number Of Working Days And Hours";
            // 
            // WokingDaysHors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 608);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sun_check);
            this.Controls.Add(this.sat_check);
            this.Controls.Add(this.fri_check);
            this.Controls.Add(this.thu_check);
            this.Controls.Add(this.wed_check);
            this.Controls.Add(this.tue_check);
            this.Controls.Add(this.mon_check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WokingDaysHors";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WokingDaysHors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox sun_check;
        private System.Windows.Forms.CheckBox sat_check;
        private System.Windows.Forms.CheckBox fri_check;
        private System.Windows.Forms.CheckBox thu_check;
        private System.Windows.Forms.CheckBox wed_check;
        private System.Windows.Forms.CheckBox tue_check;
        private System.Windows.Forms.CheckBox mon_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

