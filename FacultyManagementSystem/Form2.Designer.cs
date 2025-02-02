namespace FacultyManagementSystem
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            New = new Button();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(4, 191, 173);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(23, 32, 38);
            button1.Location = new Point(249, 177);
            button1.Name = "button1";
            button1.Size = new Size(135, 57);
            button1.TabIndex = 0;
            button1.Text = "Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(4, 191, 173);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(23, 32, 38);
            button2.Location = new Point(412, 177);
            button2.Name = "button2";
            button2.Size = new Size(135, 57);
            button2.TabIndex = 1;
            button2.Text = "Professor";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(4, 191, 173);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 12F);
            button3.ForeColor = Color.FromArgb(23, 32, 38);
            button3.Location = new Point(412, 278);
            button3.Name = "button3";
            button3.Size = new Size(135, 57);
            button3.TabIndex = 2;
            button3.Text = "Admin";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(4, 191, 173);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 12F);
            button4.ForeColor = Color.FromArgb(23, 32, 38);
            button4.Location = new Point(249, 278);
            button4.Name = "button4";
            button4.Size = new Size(135, 57);
            button4.TabIndex = 3;
            button4.Text = "Staff";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 115, 115);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(New);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 361);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(23, 32, 38);
            label5.Location = new Point(42, 279);
            label5.Name = "label5";
            label5.Size = new Size(153, 16);
            label5.TabIndex = 16;
            label5.Text = "Already have an account?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 32, 38);
            label4.Location = new Point(6, 142);
            label4.Name = "label4";
            label4.Size = new Size(221, 18);
            label4.TabIndex = 13;
            label4.Text = "Faculty Management System";
            // 
            // New
            // 
            New.BackColor = Color.FromArgb(4, 191, 173);
            New.Cursor = Cursors.Hand;
            New.FlatAppearance.BorderSize = 0;
            New.FlatStyle = FlatStyle.Flat;
            New.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            New.ForeColor = Color.FromArgb(23, 32, 38);
            New.Location = new Point(6, 310);
            New.Name = "New";
            New.Size = new Size(214, 39);
            New.TabIndex = 15;
            New.Text = "LOGIN";
            New.UseVisualStyleBackColor = false;
            New.Click += New_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_school_80;
            pictureBox1.Location = new Point(42, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(95, 205, 217);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(23, 32, 38);
            button5.Location = new Point(529, 0);
            button5.Name = "button5";
            button5.Size = new Size(32, 30);
            button5.TabIndex = 10;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 32, 38);
            label1.Location = new Point(249, 131);
            label1.Name = "label1";
            label1.Size = new Size(91, 18);
            label1.TabIndex = 14;
            label1.Text = "Register As: ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(95, 205, 217);
            ClientSize = new Size(559, 361);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Button button5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
        private Button New;
    }
}