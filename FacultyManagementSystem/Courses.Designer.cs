namespace FacultyManagementSystem
{
    partial class Courses
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
            dg = new DataGridView();
            Code = new TextBox();
            Name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Add = new Button();
            REQ = new TextBox();
            label3 = new Label();
            ID = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dg
            // 
            dg.BackgroundColor = Color.FromArgb(4, 191, 173);
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(3, 166);
            dg.Name = "dg";
            dg.Size = new Size(403, 207);
            dg.TabIndex = 11;
            // 
            // Code
            // 
            Code.Location = new Point(27, 91);
            Code.Name = "Code";
            Code.Size = new Size(165, 23);
            Code.TabIndex = 10;
            // 
            // Name
            // 
            Name.Location = new Point(27, 41);
            Name.Name = "Name";
            Name.Size = new Size(165, 23);
            Name.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 73);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 8;
            label2.Text = "Course Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 7;
            label1.Text = "Course Name";
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(23, 32, 38);
            Add.Cursor = Cursors.Hand;
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.ForeColor = Color.FromArgb(95, 205, 217);
            Add.Location = new Point(620, 58);
            Add.Name = "Add";
            Add.Size = new Size(183, 44);
            Add.TabIndex = 6;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // REQ
            // 
            REQ.Location = new Point(259, 41);
            REQ.Name = "REQ";
            REQ.Size = new Size(277, 23);
            REQ.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 23);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 12;
            label3.Text = "Course Requeriment";
            // 
            // ID
            // 
            ID.Location = new Point(264, 91);
            ID.Name = "ID";
            ID.Size = new Size(272, 23);
            ID.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 73);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 14;
            label4.Text = "Your ID";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(4, 191, 173);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(438, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(403, 207);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 191, 157);
            Controls.Add(dataGridView1);
            Controls.Add(ID);
            Controls.Add(label4);
            Controls.Add(REQ);
            Controls.Add(label3);
            Controls.Add(dg);
            Controls.Add(Code);
            Controls.Add(Name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Add);
            Size = new Size(858, 376);
            Load += Courses_Load;
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dg;
        private TextBox Code;
        private TextBox Name;
        private Label label2;
        private Label label1;
        private Button Add;
        private TextBox REQ;
        private Label label3;
        private TextBox ID;
        private Label label4;
        private DataGridView dataGridView1;
    }
}
