namespace FacultyManagementSystem
{
    partial class Form12
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
            button2 = new Button();
            show = new CheckBox();
            FName = new TextBox();
            pictureBox1 = new PictureBox();
            ID = new TextBox();
            label8 = new Label();
            label1 = new Label();
            label7 = new Label();
            Password = new TextBox();
            LName = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            New = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(95, 205, 217);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(23, 32, 38);
            button2.Location = new Point(543, 0);
            button2.Name = "button2";
            button2.Size = new Size(32, 30);
            button2.TabIndex = 41;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // show
            // 
            show.AutoSize = true;
            show.Cursor = Cursors.Hand;
            show.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show.Location = new Point(439, 322);
            show.Name = "show";
            show.Size = new Size(108, 19);
            show.TabIndex = 40;
            show.Text = "Show Password";
            show.UseVisualStyleBackColor = true;
            show.CheckedChanged += show_CheckedChanged;
            // 
            // FName
            // 
            FName.Font = new Font("Tahoma", 11.25F);
            FName.Location = new Point(276, 163);
            FName.Name = "FName";
            FName.Size = new Size(270, 26);
            FName.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_school_80;
            pictureBox1.Location = new Point(47, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // ID
            // 
            ID.Font = new Font("Tahoma", 11.25F);
            ID.Location = new Point(277, 98);
            ID.Name = "ID";
            ID.Size = new Size(270, 26);
            ID.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(23, 32, 38);
            label8.Location = new Point(11, 142);
            label8.Name = "label8";
            label8.Size = new Size(221, 18);
            label8.TabIndex = 22;
            label8.Text = "Faculty Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 27);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 27;
            label1.Text = "Staff SIGNUP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(23, 32, 38);
            label7.Location = new Point(47, 318);
            label7.Name = "label7";
            label7.Size = new Size(153, 16);
            label7.TabIndex = 24;
            label7.Text = "Already have an account?";
            // 
            // Password
            // 
            Password.Font = new Font("Tahoma", 11.25F);
            Password.Location = new Point(276, 289);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(271, 26);
            Password.TabIndex = 37;
            // 
            // LName
            // 
            LName.Font = new Font("Tahoma", 11.25F);
            LName.Location = new Point(277, 229);
            LName.Name = "LName";
            LName.Size = new Size(270, 26);
            LName.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F);
            label6.Location = new Point(276, 268);
            label6.Name = "label6";
            label6.Size = new Size(84, 18);
            label6.TabIndex = 34;
            label6.Text = "Password : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F);
            label4.Location = new Point(277, 208);
            label4.Name = "label4";
            label4.Size = new Size(109, 18);
            label4.TabIndex = 32;
            label4.Text = "Second Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F);
            label3.Location = new Point(276, 142);
            label3.Name = "label3";
            label3.Size = new Size(89, 18);
            label3.TabIndex = 31;
            label3.Text = "First Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F);
            label2.Location = new Point(277, 77);
            label2.Name = "label2";
            label2.Size = new Size(34, 18);
            label2.TabIndex = 30;
            label2.Text = "ID :";
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
            panel1.TabIndex = 29;
            // 
            // New
            // 
            New.BackColor = Color.FromArgb(4, 191, 173);
            New.Cursor = Cursors.Hand;
            New.FlatAppearance.BorderSize = 0;
            New.FlatStyle = FlatStyle.Flat;
            New.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            New.ForeColor = Color.FromArgb(23, 32, 38);
            New.Location = new Point(11, 349);
            New.Name = "New";
            New.Size = new Size(214, 39);
            New.TabIndex = 23;
            New.Text = "LOGIN";
            New.UseVisualStyleBackColor = false;
            New.Click += New_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(4, 191, 173);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 11.25F);
            button1.ForeColor = Color.FromArgb(23, 32, 38);
            button1.Location = new Point(310, 349);
            button1.Name = "button1";
            button1.Size = new Size(214, 39);
            button1.TabIndex = 28;
            button1.Text = "SIGNUP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(95, 205, 217);
            ClientSize = new Size(575, 400);
            Controls.Add(button2);
            Controls.Add(show);
            Controls.Add(FName);
            Controls.Add(ID);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(LName);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form12";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form12";
            Load += Form12_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private CheckBox show;
        private TextBox FName;
        private PictureBox pictureBox1;
        private TextBox ID;
        private Label label8;
        private Label label1;
        private Label label7;
        private TextBox Password;
        private TextBox LName;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Button New;
        private Button button1;
    }
}