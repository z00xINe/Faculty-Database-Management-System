namespace FacultyManagementSystem
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            Title = new Label();
            label1 = new Label();
            dep = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            ID = new TextBox();
            Code = new TextBox();
            label4 = new Label();
            Grade = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            label8 = new Label();
            New = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(476, 125);
            Title.Name = "Title";
            Title.Size = new Size(389, 40);
            Title.TabIndex = 1;
            Title.Text = "Welecome Professor Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 210);
            label1.Name = "label1";
            label1.Size = new Size(168, 19);
            label1.TabIndex = 3;
            label1.Text = "Assign To Department";
            // 
            // dep
            // 
            dep.BackColor = Color.FromArgb(4, 191, 157);
            dep.FormattingEnabled = true;
            dep.Location = new Point(536, 210);
            dep.Name = "dep";
            dep.Size = new Size(240, 23);
            dep.TabIndex = 4;
            dep.SelectedIndexChanged += dep_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(354, 258);
            label2.Name = "label2";
            label2.Size = new Size(184, 23);
            label2.TabIndex = 5;
            label2.Text = "Set Student Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F);
            label3.Location = new Point(390, 312);
            label3.Name = "label3";
            label3.Size = new Size(79, 18);
            label3.TabIndex = 6;
            label3.Text = "Student ID";
            // 
            // ID
            // 
            ID.BackColor = Color.FromArgb(4, 191, 157);
            ID.Location = new Point(390, 345);
            ID.Name = "ID";
            ID.Size = new Size(196, 23);
            ID.TabIndex = 7;
            // 
            // Code
            // 
            Code.BackColor = Color.FromArgb(4, 191, 157);
            Code.Location = new Point(620, 345);
            Code.Name = "Code";
            Code.Size = new Size(199, 23);
            Code.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F);
            label4.Location = new Point(616, 312);
            label4.Name = "label4";
            label4.Size = new Size(91, 18);
            label4.TabIndex = 8;
            label4.Text = "Course Code";
            // 
            // Grade
            // 
            Grade.BackColor = Color.FromArgb(4, 191, 157);
            Grade.Location = new Point(880, 345);
            Grade.Name = "Grade";
            Grade.Size = new Size(189, 23);
            Grade.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F);
            label5.Location = new Point(880, 312);
            label5.Name = "label5";
            label5.Size = new Size(47, 18);
            label5.TabIndex = 10;
            label5.Text = "Grade";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 32, 38);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(95, 205, 217);
            button1.Location = new Point(578, 396);
            button1.Name = "button1";
            button1.Size = new Size(241, 47);
            button1.TabIndex = 12;
            button1.Text = "Set";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(23, 32, 38);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(95, 205, 217);
            button2.Location = new Point(869, 197);
            button2.Name = "button2";
            button2.Size = new Size(173, 47);
            button2.TabIndex = 13;
            button2.Text = "Assign";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 115, 115);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(New);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 600);
            panel2.TabIndex = 25;
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
            New.Location = new Point(12, 531);
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
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(249, 0);
            button3.Name = "button3";
            button3.Size = new Size(96, 93);
            button3.TabIndex = 26;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(620, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
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
            button5.TabIndex = 44;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(4, 191, 157);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(249, 450);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(839, 150);
            dataGridView1.TabIndex = 45;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(95, 205, 217);
            ClientSize = new Size(1100, 600);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Grade);
            Controls.Add(label5);
            Controls.Add(Code);
            Controls.Add(label4);
            Controls.Add(ID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dep);
            Controls.Add(label1);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            Load += Form8_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private ComboBox dep;
        private Label label2;
        private Label label3;
        private TextBox ID;
        private TextBox Code;
        private Label label4;
        private TextBox Grade;
        private Label label5;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private Label label8;
        private Button New;
        private PictureBox pictureBox1;
        private Button button3;
        private PictureBox pictureBox2;
        private Button button5;
        private DataGridView dataGridView1;
    }
}