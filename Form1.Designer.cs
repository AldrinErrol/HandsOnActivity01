namespace OrganizationProfile
{
    partial class Form1
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
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.cbPrograms = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(100, 35);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(178, 20);
            this.txtStudentNo.TabIndex = 0;
            this.txtStudentNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(100, 86);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(178, 20);
            this.txtLastname.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(100, 136);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(82, 20);
            this.txtAge.TabIndex = 2;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(724, 86);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(82, 20);
            this.txtMiddleInitial.TabIndex = 3;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(499, 86);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(178, 20);
            this.txtFirstname.TabIndex = 4;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(691, 238);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(115, 20);
            this.txtContactNo.TabIndex = 5;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            // 
            // cbPrograms
            // 
            this.cbPrograms.FormattingEnabled = true;
            this.cbPrograms.Location = new System.Drawing.Point(499, 35);
            this.cbPrograms.Name = "cbPrograms";
            this.cbPrograms.Size = new System.Drawing.Size(307, 21);
            this.cbPrograms.TabIndex = 6;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(499, 135);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(117, 21);
            this.cbGender.TabIndex = 7;
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.Location = new System.Drawing.Point(100, 182);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(200, 20);
            this.datePickerBirthday.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Birthday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Program:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "First Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Contact No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(683, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "M.I.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 317);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datePickerBirthday);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbPrograms);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtStudentNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.ComboBox cbPrograms;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker datePickerBirthday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

