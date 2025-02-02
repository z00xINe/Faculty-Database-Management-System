namespace FacultyManagementSystem
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            Title = new Label();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            New = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            button5 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(520, 94);
            Title.Name = "Title";
            Title.Size = new Size(322, 40);
            Title.TabIndex = 5;
            Title.Text = "Welecome Staff Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 32, 38);
            label1.Location = new Point(381, 309);
            label1.Name = "label1";
            label1.Size = new Size(249, 33);
            label1.TabIndex = 7;
            label1.Text = "Your Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(23, 32, 38);
            label3.Location = new Point(686, 309);
            label3.Name = "label3";
            label3.Size = new Size(47, 33);
            label3.TabIndex = 9;
            label3.Text = "Cs";
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
            panel2.TabIndex = 26;
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
            button3.TabIndex = 27;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(623, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
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
            button5.Location = new Point(1070, 0);
            button5.Name = "button5";
            button5.Size = new Size(32, 30);
            button5.TabIndex = 45;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(95, 205, 217);
            ClientSize = new Size(1100, 600);
            Controls.Add(button5);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form13";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form13";
            Load += Form13_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Title;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private Label label8;
        private Button New;
        private PictureBox pictureBox1;
        private Button button3;
        private PictureBox pictureBox2;
        private Button button5;
    }
}