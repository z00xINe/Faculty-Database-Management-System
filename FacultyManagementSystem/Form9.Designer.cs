namespace FacultyManagementSystem
{
    partial class Form9
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
            FName = new TextBox();
            ID = new TextBox();
            Password = new TextBox();
            Email = new TextBox();
            LName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Save = new Button();
            Delete = new Button();
            show = new CheckBox();
            panel1 = new Panel();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FName
            // 
            FName.Font = new Font("Tahoma", 11.25F);
            FName.Location = new Point(56, 84);
            FName.Name = "FName";
            FName.Size = new Size(199, 26);
            FName.TabIndex = 21;
            // 
            // ID
            // 
            ID.Font = new Font("Tahoma", 11.25F);
            ID.Location = new Point(56, 36);
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Size = new Size(199, 26);
            ID.TabIndex = 20;
            // 
            // Password
            // 
            Password.Font = new Font("Tahoma", 11.25F);
            Password.Location = new Point(56, 225);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(199, 26);
            Password.TabIndex = 19;
            // 
            // Email
            // 
            Email.Font = new Font("Tahoma", 11.25F);
            Email.Location = new Point(56, 177);
            Email.Name = "Email";
            Email.Size = new Size(199, 26);
            Email.TabIndex = 18;
            // 
            // LName
            // 
            LName.Font = new Font("Tahoma", 11.25F);
            LName.Location = new Point(56, 129);
            LName.Name = "LName";
            LName.Size = new Size(199, 26);
            LName.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F);
            label6.Location = new Point(56, 206);
            label6.Name = "label6";
            label6.Size = new Size(62, 16);
            label6.TabIndex = 16;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F);
            label5.Location = new Point(56, 158);
            label5.Name = "label5";
            label5.Size = new Size(38, 16);
            label5.TabIndex = 15;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F);
            label4.Location = new Point(56, 110);
            label4.Name = "label4";
            label4.Size = new Size(86, 16);
            label4.TabIndex = 14;
            label4.Text = "Second Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F);
            label3.Location = new Point(56, 65);
            label3.Name = "label3";
            label3.Size = new Size(69, 16);
            label3.TabIndex = 13;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F);
            label2.Location = new Point(56, 15);
            label2.Name = "label2";
            label2.Size = new Size(19, 16);
            label2.TabIndex = 12;
            label2.Text = "ID";
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(23, 32, 38);
            Save.Cursor = Cursors.Hand;
            Save.FlatAppearance.BorderSize = 0;
            Save.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save.ForeColor = Color.FromArgb(95, 205, 217);
            Save.Location = new Point(56, 282);
            Save.Name = "Save";
            Save.Size = new Size(199, 54);
            Save.TabIndex = 22;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(95, 205, 217);
            Delete.Cursor = Cursors.Hand;
            Delete.FlatAppearance.BorderSize = 0;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Image = Properties.Resources.icons8_delete_account_64;
            Delete.Location = new Point(12, 316);
            Delete.Name = "Delete";
            Delete.Size = new Size(113, 72);
            Delete.TabIndex = 24;
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // show
            // 
            show.AutoSize = true;
            show.Cursor = Cursors.Hand;
            show.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show.Location = new Point(147, 257);
            show.Name = "show";
            show.Size = new Size(108, 19);
            show.TabIndex = 40;
            show.Text = "Show Password";
            show.UseVisualStyleBackColor = true;
            show.CheckedChanged += show_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 115, 115);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(show);
            panel1.Controls.Add(Save);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ID);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(FName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(LName);
            panel1.Location = new Point(131, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 355);
            panel1.TabIndex = 41;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(95, 205, 217);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(23, 32, 38);
            button5.Location = new Point(544, 0);
            button5.Name = "button5";
            button5.Size = new Size(32, 30);
            button5.TabIndex = 45;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(95, 205, 217);
            ClientSize = new Size(575, 400);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(Delete);
            ForeColor = Color.FromArgb(23, 32, 38);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form9";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form9";
            Load += Form9_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox FName;
        private TextBox ID;
        private TextBox Password;
        private TextBox Email;
        private TextBox LName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button Save;
        private Button Delete;
        private CheckBox show;
        private Panel panel1;
        private Button button5;
    }
}