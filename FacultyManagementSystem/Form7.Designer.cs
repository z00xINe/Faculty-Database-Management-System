namespace FacultyManagementSystem
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            Title = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            Student = new Student();
            Staff = new Staff();
            Department = new Department();
            Course = new Courses();
            panel2 = new Panel();
            label8 = new Label();
            New = new Button();
            pictureBox1 = new PictureBox();
            Edit = new Button();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(489, 99);
            Title.Name = "Title";
            Title.Size = new Size(349, 40);
            Title.TabIndex = 1;
            Title.Text = "Welecome Admin Name";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(95, 205, 217);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 205, 217);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(23, 32, 38);
            button1.Image = Properties.Resources.icons8_courses_64;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 163);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 30, 0);
            button1.Size = new Size(237, 72);
            button1.TabIndex = 3;
            button1.Text = "Add Course";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(95, 205, 217);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 205, 217);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(23, 32, 38);
            button2.Image = Properties.Resources.icons8_courses_641;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 319);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 20, 0);
            button2.Size = new Size(237, 72);
            button2.TabIndex = 4;
            button2.Text = "Enroll student\r\n into course";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(95, 205, 217);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 205, 217);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(23, 32, 38);
            button3.Image = Properties.Resources.icons8_department_50;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 241);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 20, 0);
            button3.Size = new Size(237, 72);
            button3.TabIndex = 5;
            button3.Text = "Add Department";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(95, 205, 217);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 205, 217);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(23, 32, 38);
            button4.Image = Properties.Resources.icons8_staff_50;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 397);
            button4.Name = "button4";
            button4.Padding = new Padding(60, 0, 60, 0);
            button4.Size = new Size(237, 72);
            button4.TabIndex = 6;
            button4.Text = "Staff";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Student);
            panel1.Controls.Add(Staff);
            panel1.Controls.Add(Department);
            panel1.Controls.Add(Course);
            panel1.Location = new Point(246, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 376);
            panel1.TabIndex = 7;
            // 
            // Student
            // 
            Student.AutoValidate = AutoValidate.EnableAllowFocusChange;
            Student.BackColor = Color.FromArgb(4, 191, 157);
            Student.ForeColor = Color.FromArgb(23, 32, 38);
            Student.Location = new Point(0, 0);
            Student.Name = "Student";
            Student.Size = new Size(854, 376);
            Student.TabIndex = 3;
            Student.Load += Student_Load;
            // 
            // Staff
            // 
            Staff.BackColor = Color.FromArgb(4, 191, 157);
            Staff.Dock = DockStyle.Fill;
            Staff.Location = new Point(0, 0);
            Staff.Name = "Staff";
            Staff.Size = new Size(854, 376);
            Staff.TabIndex = 2;
            // 
            // Department
            // 
            Department.BackColor = Color.FromArgb(4, 191, 157);
            Department.Dock = DockStyle.Fill;
            Department.Location = new Point(0, 0);
            Department.Name = "Department";
            Department.Size = new Size(854, 376);
            Department.TabIndex = 1;
            // 
            // Course
            // 
            Course.BackColor = Color.FromArgb(4, 191, 157);
            Course.Dock = DockStyle.Fill;
            Course.Location = new Point(0, 0);
            Course.Name = "Course";
            Course.Size = new Size(854, 376);
            Course.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 115, 115);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(New);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 600);
            panel2.TabIndex = 24;
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
            // New
            // 
            New.BackColor = Color.FromArgb(4, 191, 173);
            New.Cursor = Cursors.Hand;
            New.FlatAppearance.BorderSize = 0;
            New.FlatStyle = FlatStyle.Flat;
            New.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            New.ForeColor = Color.FromArgb(23, 32, 38);
            New.Location = new Point(12, 532);
            New.Name = "New";
            New.Size = new Size(214, 39);
            New.TabIndex = 23;
            New.Text = "SIGNOUT";
            New.UseVisualStyleBackColor = false;
            New.Click += New_Click;
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
            // Edit
            // 
            Edit.BackColor = Color.Transparent;
            Edit.Cursor = Cursors.Hand;
            Edit.FlatAppearance.BorderSize = 0;
            Edit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Edit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.Location = new Point(249, 0);
            Edit.Name = "Edit";
            Edit.Size = new Size(96, 93);
            Edit.TabIndex = 24;
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(95, 205, 217);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(23, 32, 38);
            button5.Location = new Point(1068, 0);
            button5.Name = "button5";
            button5.Size = new Size(32, 30);
            button5.TabIndex = 41;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(605, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(95, 205, 217);
            ClientSize = new Size(1100, 600);
            Controls.Add(pictureBox2);
            Controls.Add(button5);
            Controls.Add(Edit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            Load += Form7_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Courses courses1;
        private Panel panel2;
        private Label label8;
        private Button New;
        private PictureBox pictureBox1;
        private Button Edit;
        private Button button5;
        private PictureBox pictureBox2;
        private Student Student;
        private Staff Staff;
        private Department Department;
        private Courses Course;
    }
}