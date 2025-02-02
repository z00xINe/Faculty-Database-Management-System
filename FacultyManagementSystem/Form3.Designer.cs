namespace FacultyManagementSystem
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            LName = new TextBox();
            Email = new TextBox();
            Password = new TextBox();
            ID = new TextBox();
            FName = new TextBox();
            Create = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            New = new Button();
            pictureBox1 = new PictureBox();
            show = new CheckBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 22);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 0;
            label1.Text = "Student SIGNUP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F);
            label2.Location = new Point(283, 56);
            label2.Name = "label2";
            label2.Size = new Size(34, 18);
            label2.TabIndex = 1;
            label2.Text = "ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F);
            label3.Location = new Point(283, 106);
            label3.Name = "label3";
            label3.Size = new Size(89, 18);
            label3.TabIndex = 2;
            label3.Text = "First Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F);
            label4.Location = new Point(283, 161);
            label4.Name = "label4";
            label4.Size = new Size(109, 18);
            label4.TabIndex = 3;
            label4.Text = "Second Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F);
            label5.Location = new Point(283, 211);
            label5.Name = "label5";
            label5.Size = new Size(51, 18);
            label5.TabIndex = 4;
            label5.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F);
            label6.Location = new Point(282, 261);
            label6.Name = "label6";
            label6.Size = new Size(84, 18);
            label6.TabIndex = 5;
            label6.Text = "Password : ";
            // 
            // LName
            // 
            LName.Font = new Font("Tahoma", 11.25F);
            LName.Location = new Point(283, 182);
            LName.Name = "LName";
            LName.Size = new Size(270, 26);
            LName.TabIndex = 6;
            // 
            // Email
            // 
            Email.Font = new Font("Tahoma", 11.25F);
            Email.Location = new Point(283, 232);
            Email.Name = "Email";
            Email.Size = new Size(270, 26);
            Email.TabIndex = 7;
            // 
            // Password
            // 
            Password.Font = new Font("Tahoma", 11.25F);
            Password.Location = new Point(282, 282);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(271, 26);
            Password.TabIndex = 8;
            // 
            // ID
            // 
            ID.Font = new Font("Tahoma", 11.25F);
            ID.Location = new Point(283, 77);
            ID.Name = "ID";
            ID.Size = new Size(270, 26);
            ID.TabIndex = 9;
            // 
            // FName
            // 
            FName.Font = new Font("Tahoma", 11.25F);
            FName.Location = new Point(283, 127);
            FName.Name = "FName";
            FName.Size = new Size(270, 26);
            FName.TabIndex = 10;
            // 
            // Create
            // 
            Create.BackColor = Color.FromArgb(4, 191, 173);
            Create.Cursor = Cursors.Hand;
            Create.FlatAppearance.BorderSize = 0;
            Create.FlatStyle = FlatStyle.Flat;
            Create.Font = new Font("Tahoma", 11.25F);
            Create.ForeColor = Color.FromArgb(23, 32, 38);
            Create.Location = new Point(295, 349);
            Create.Name = "Create";
            Create.Size = new Size(214, 39);
            Create.TabIndex = 11;
            Create.Text = "SIGNUP";
            Create.UseVisualStyleBackColor = false;
            Create.Click += Create_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 115, 115);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(New);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 400);
            panel1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(23, 32, 38);
            label7.Location = new Point(48, 318);
            label7.Name = "label7";
            label7.Size = new Size(153, 16);
            label7.TabIndex = 20;
            label7.Text = "Already have an account?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(23, 32, 38);
            label8.Location = new Point(12, 142);
            label8.Name = "label8";
            label8.Size = new Size(221, 18);
            label8.TabIndex = 18;
            label8.Text = "Faculty Management System";
            // 
            // New
            // 
            New.BackColor = Color.FromArgb(4, 191, 173);
            New.Cursor = Cursors.Hand;
            New.FlatAppearance.BorderSize = 0;
            New.FlatStyle = FlatStyle.Flat;
            New.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            New.ForeColor = Color.FromArgb(23, 32, 38);
            New.Location = new Point(12, 349);
            New.Name = "New";
            New.Size = new Size(214, 39);
            New.TabIndex = 19;
            New.Text = "LOGIN";
            New.UseVisualStyleBackColor = false;
            New.Click += New_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_school_80;
            pictureBox1.Location = new Point(48, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // show
            // 
            show.AutoSize = true;
            show.Cursor = Cursors.Hand;
            show.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show.Location = new Point(445, 314);
            show.Name = "show";
            show.Size = new Size(108, 19);
            show.TabIndex = 14;
            show.Text = "Show Password";
            show.UseVisualStyleBackColor = true;
            show.CheckedChanged += show_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(95, 205, 217);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(23, 32, 38);
            button1.Location = new Point(544, 0);
            button1.Name = "button1";
            button1.Size = new Size(32, 30);
            button1.TabIndex = 15;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(95, 205, 217);
            ClientSize = new Size(575, 400);
            Controls.Add(button1);
            Controls.Add(show);
            Controls.Add(panel1);
            Controls.Add(Create);
            Controls.Add(FName);
            Controls.Add(ID);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(LName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox LName;
        private TextBox Email;
        private TextBox Password;
        private TextBox ID;
        private TextBox FName;
        private Button Create;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private Button New;
        private PictureBox pictureBox1;
        private CheckBox show;
        private Button button1;
    }
}