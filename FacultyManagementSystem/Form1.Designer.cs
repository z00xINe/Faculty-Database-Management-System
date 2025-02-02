namespace FacultyManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            ID = new TextBox();
            Password = new TextBox();
            login = new Button();
            New = new Button();
            show = new CheckBox();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 116);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 0;
            label1.Text = "User ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(262, 194);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // ID
            // 
            ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ID.Location = new Point(262, 149);
            ID.Name = "ID";
            ID.Size = new Size(299, 29);
            ID.TabIndex = 2;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(262, 225);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(299, 29);
            Password.TabIndex = 3;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(4, 191, 173);
            login.Cursor = Cursors.Hand;
            login.FlatAppearance.BorderSize = 0;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            login.ForeColor = Color.FromArgb(23, 32, 38);
            login.Location = new Point(262, 295);
            login.Name = "login";
            login.Size = new Size(123, 39);
            login.TabIndex = 4;
            login.Text = "LOGIN";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // New
            // 
            New.BackColor = Color.FromArgb(4, 191, 173);
            New.Cursor = Cursors.Hand;
            New.FlatAppearance.BorderSize = 0;
            New.FlatStyle = FlatStyle.Flat;
            New.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            New.ForeColor = Color.FromArgb(23, 32, 38);
            New.Location = new Point(12, 349);
            New.Name = "New";
            New.Size = new Size(214, 39);
            New.TabIndex = 5;
            New.Text = "SIGNUP";
            New.UseVisualStyleBackColor = false;
            New.Click += New_Click;
            // 
            // show
            // 
            show.AutoSize = true;
            show.Cursor = Cursors.Hand;
            show.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show.Location = new Point(453, 260);
            show.Name = "show";
            show.Size = new Size(108, 19);
            show.TabIndex = 7;
            show.Text = "Show Password";
            show.UseVisualStyleBackColor = true;
            show.CheckedChanged += show_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 115, 115);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(New);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 400);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(23, 32, 38);
            label5.Location = new Point(48, 318);
            label5.Name = "label5";
            label5.Size = new Size(133, 16);
            label5.TabIndex = 12;
            label5.Text = "Register Your Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 32, 38);
            label4.Location = new Point(12, 149);
            label4.Name = "label4";
            label4.Size = new Size(221, 18);
            label4.TabIndex = 11;
            label4.Text = "Faculty Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_school_80;
            pictureBox1.Location = new Point(48, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(95, 205, 217);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(23, 32, 38);
            button1.Location = new Point(543, 0);
            button1.Name = "button1";
            button1.Size = new Size(32, 30);
            button1.TabIndex = 9;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(23, 32, 38);
            label3.Location = new Point(262, 44);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 10;
            label3.Text = "Login Account";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(95, 205, 217);
            ClientSize = new Size(575, 400);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(show);
            Controls.Add(login);
            Controls.Add(Password);
            Controls.Add(ID);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ID;
        private TextBox Password;
        private Button login;
        private Button New;
        private CheckBox show;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
