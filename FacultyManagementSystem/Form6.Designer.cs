namespace FacultyManagementSystem
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            Title = new Label();
            Edit = new Button();
            label1 = new Label();
            Dep = new ComboBox();
            button1 = new Button();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            New = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(513, 154);
            Title.Name = "Title";
            Title.Size = new Size(275, 25);
            Title.TabIndex = 0;
            Title.Text = "Welecome Student Name";
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
            Edit.Location = new Point(233, -9);
            Edit.Name = "Edit";
            Edit.Size = new Size(96, 93);
            Edit.TabIndex = 1;
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(433, 279);
            label1.Name = "label1";
            label1.Size = new Size(145, 19);
            label1.TabIndex = 2;
            label1.Text = "Choose Your Major";
            // 
            // Dep
            // 
            Dep.BackColor = Color.FromArgb(4, 191, 173);
            Dep.FormattingEnabled = true;
            Dep.Location = new Point(593, 279);
            Dep.Name = "Dep";
            Dep.Size = new Size(202, 23);
            Dep.TabIndex = 3;
            Dep.SelectedIndexChanged += Dep_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(4, 191, 173);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F);
            button1.Location = new Point(464, 352);
            button1.Name = "button1";
            button1.Size = new Size(331, 41);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 115, 115);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(New);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 600);
            panel1.TabIndex = 23;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(593, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(95, 205, 217);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(23, 32, 38);
            button2.Location = new Point(1070, 0);
            button2.Name = "button2";
            button2.Size = new Size(32, 30);
            button2.TabIndex = 40;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(4, 191, 157);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(269, 438);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(808, 150);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(95, 205, 217);
            ClientSize = new Size(1100, 600);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(Dep);
            Controls.Add(label1);
            Controls.Add(Edit);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button Edit;
        private Label label1;
        private ComboBox Dep;
        private Button button1;
        private Label label8;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button New;
        private PictureBox pictureBox2;
        private Button button2;
        private DataGridView dataGridView1;
    }
}