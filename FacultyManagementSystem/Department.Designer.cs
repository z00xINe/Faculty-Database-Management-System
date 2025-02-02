namespace FacultyManagementSystem
{
    partial class Department
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            Name = new TextBox();
            Code = new TextBox();
            dataGridView1 = new DataGridView();
            ID = new TextBox();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 32, 38);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(95, 205, 217);
            button1.Location = new Point(527, 66);
            button1.Name = "button1";
            button1.Size = new Size(192, 41);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 21);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Department Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 87);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 2;
            label2.Text = "Department Code";
            // 
            // Name
            // 
            Name.Location = new Point(57, 39);
            Name.Name = "Name";
            Name.Size = new Size(165, 23);
            Name.TabIndex = 3;
            // 
            // Code
            // 
            Code.Location = new Point(52, 105);
            Code.Name = "Code";
            Code.Size = new Size(165, 23);
            Code.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(4, 191, 173);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(425, 221);
            dataGridView1.TabIndex = 5;
            // 
            // ID
            // 
            ID.Location = new Point(263, 84);
            ID.Name = "ID";
            ID.Size = new Size(165, 23);
            ID.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 58);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "Your ID";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(4, 191, 173);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(430, 152);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(425, 221);
            dataGridView2.TabIndex = 8;
            // 
            // Department
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 191, 157);
            Controls.Add(dataGridView2);
            Controls.Add(ID);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(Code);
            Controls.Add(Name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Size = new Size(858, 376);
            Load += Department_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox Name;
        private TextBox Code;
        private DataGridView dataGridView1;
        private TextBox ID;
        private Label label3;
        private DataGridView dataGridView2;
    }
}
