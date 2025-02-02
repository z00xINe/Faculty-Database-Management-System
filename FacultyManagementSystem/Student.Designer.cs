namespace FacultyManagementSystem
{
    partial class Student
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            Id = new TextBox();
            Code = new TextBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(95, 205, 217);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(852, 119);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(95, 205, 217);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 240);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(852, 133);
            dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 24);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "Student ID";
            // 
            // Id
            // 
            Id.Location = new Point(40, 42);
            Id.Name = "Id";
            Id.Size = new Size(140, 23);
            Id.TabIndex = 3;
            // 
            // Code
            // 
            Code.Location = new Point(236, 42);
            Code.Name = "Code";
            Code.Size = new Size(152, 23);
            Code.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 24);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 4;
            label2.Text = "Course Code";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 32, 38);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(95, 205, 217);
            button1.Location = new Point(582, 24);
            button1.Name = "button1";
            button1.Size = new Size(156, 41);
            button1.TabIndex = 6;
            button1.Text = "Assign";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(4, 191, 157);
            Controls.Add(button1);
            Controls.Add(Code);
            Controls.Add(label2);
            Controls.Add(Id);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Student";
            Size = new Size(858, 376);
            Load += Student_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private TextBox Id;
        private TextBox Code;
        private Label label2;
        private Button button1;
    }
}
