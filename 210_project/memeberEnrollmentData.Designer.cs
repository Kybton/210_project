namespace _210_project
{
    partial class memeberEnrollmentData
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
            this.enrolDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unenrollBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalEnrollLbl = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.trainerIDLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enrollIDLbl = new System.Windows.Forms.Label();
            this.trainerComBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enrolDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // enrolDataGridView
            // 
            this.enrolDataGridView.AllowUserToAddRows = false;
            this.enrolDataGridView.AllowUserToDeleteRows = false;
            this.enrolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrolDataGridView.Location = new System.Drawing.Point(17, 25);
            this.enrolDataGridView.Name = "enrolDataGridView";
            this.enrolDataGridView.ReadOnly = true;
            this.enrolDataGridView.RowHeadersWidth = 51;
            this.enrolDataGridView.RowTemplate.Height = 24;
            this.enrolDataGridView.Size = new System.Drawing.Size(836, 246);
            this.enrolDataGridView.TabIndex = 0;
            this.enrolDataGridView.SelectionChanged += new System.EventHandler(this.enrolDataGridView_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enrolDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrolled Classes";
            // 
            // unenrollBtn
            // 
            this.unenrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unenrollBtn.Font = new System.Drawing.Font("SimSun", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unenrollBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.unenrollBtn.Location = new System.Drawing.Point(752, 168);
            this.unenrollBtn.Name = "unenrollBtn";
            this.unenrollBtn.Size = new System.Drawing.Size(102, 42);
            this.unenrollBtn.TabIndex = 2;
            this.unenrollBtn.Text = "Unenroll";
            this.unenrollBtn.UseVisualStyleBackColor = true;
            this.unenrollBtn.Click += new System.EventHandler(this.unenrollBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalEnrollLbl);
            this.groupBox2.Controls.Add(this.updateBtn);
            this.groupBox2.Controls.Add(this.trainerIDLbl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.titleLbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.enrollIDLbl);
            this.groupBox2.Controls.Add(this.trainerComBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.unenrollBtn);
            this.groupBox2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 239);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Box";
            // 
            // totalEnrollLbl
            // 
            this.totalEnrollLbl.AutoSize = true;
            this.totalEnrollLbl.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEnrollLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(251)))));
            this.totalEnrollLbl.Location = new System.Drawing.Point(616, 37);
            this.totalEnrollLbl.Name = "totalEnrollLbl";
            this.totalEnrollLbl.Size = new System.Drawing.Size(37, 22);
            this.totalEnrollLbl.TabIndex = 14;
            this.totalEnrollLbl.Text = "aaa";
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("SimSun", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.updateBtn.Location = new System.Drawing.Point(620, 168);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(102, 42);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // trainerIDLbl
            // 
            this.trainerIDLbl.AutoSize = true;
            this.trainerIDLbl.Location = new System.Drawing.Point(442, 58);
            this.trainerIDLbl.Name = "trainerIDLbl";
            this.trainerIDLbl.Size = new System.Drawing.Size(0, 19);
            this.trainerIDLbl.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Trainer ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Trainer Name";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(143, 120);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(0, 19);
            this.titleLbl.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title";
            // 
            // enrollIDLbl
            // 
            this.enrollIDLbl.AutoSize = true;
            this.enrollIDLbl.Location = new System.Drawing.Point(143, 58);
            this.enrollIDLbl.Name = "enrollIDLbl";
            this.enrollIDLbl.Size = new System.Drawing.Size(0, 19);
            this.enrollIDLbl.TabIndex = 5;
            // 
            // trainerComBox
            // 
            this.trainerComBox.FormattingEnabled = true;
            this.trainerComBox.Location = new System.Drawing.Point(446, 117);
            this.trainerComBox.Name = "trainerComBox";
            this.trainerComBox.Size = new System.Drawing.Size(121, 27);
            this.trainerComBox.TabIndex = 4;
            this.trainerComBox.SelectedIndexChanged += new System.EventHandler(this.trainerComBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enroll ID";
            // 
            // memeberEnrollmentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(893, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "memeberEnrollmentData";
            this.Text = "memeberEnrollmentData";
            this.Load += new System.EventHandler(this.memeberEnrollmentData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrolDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView enrolDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button unenrollBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label trainerIDLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label enrollIDLbl;
        private System.Windows.Forms.ComboBox trainerComBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalEnrollLbl;
    }
}