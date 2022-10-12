namespace _210_project
{
    partial class memberClass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.classDataGridView = new System.Windows.Forms.DataGridView();
            this.trainerDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.enrollBtn = new System.Windows.Forms.Button();
            this.classIDLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.nosLbl = new System.Windows.Forms.Label();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.endDateLbl = new System.Windows.Forms.Label();
            this.trainerIDLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trainerDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.groupBox2.Location = new System.Drawing.Point(518, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trainers";
            // 
            // classDataGridView
            // 
            this.classDataGridView.AllowUserToAddRows = false;
            this.classDataGridView.AllowUserToDeleteRows = false;
            this.classDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDataGridView.Location = new System.Drawing.Point(6, 27);
            this.classDataGridView.Name = "classDataGridView";
            this.classDataGridView.ReadOnly = true;
            this.classDataGridView.RowHeadersWidth = 51;
            this.classDataGridView.RowTemplate.Height = 24;
            this.classDataGridView.Size = new System.Drawing.Size(479, 197);
            this.classDataGridView.TabIndex = 0;
            this.classDataGridView.SelectionChanged += new System.EventHandler(this.classDataGridView_SelectionChanged);
            // 
            // trainerDataGridView
            // 
            this.trainerDataGridView.AllowUserToAddRows = false;
            this.trainerDataGridView.AllowUserToDeleteRows = false;
            this.trainerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainerDataGridView.Location = new System.Drawing.Point(6, 27);
            this.trainerDataGridView.Name = "trainerDataGridView";
            this.trainerDataGridView.ReadOnly = true;
            this.trainerDataGridView.RowHeadersWidth = 51;
            this.trainerDataGridView.RowTemplate.Height = 24;
            this.trainerDataGridView.Size = new System.Drawing.Size(351, 197);
            this.trainerDataGridView.TabIndex = 1;
            this.trainerDataGridView.SelectionChanged += new System.EventHandler(this.trainerDataGridView_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nameLbl);
            this.groupBox3.Controls.Add(this.trainerIDLbl);
            this.groupBox3.Controls.Add(this.endDateLbl);
            this.groupBox3.Controls.Add(this.startDateLbl);
            this.groupBox3.Controls.Add(this.nosLbl);
            this.groupBox3.Controls.Add(this.categoryLbl);
            this.groupBox3.Controls.Add(this.titleLbl);
            this.groupBox3.Controls.Add(this.classIDLbl);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.groupBox3.Location = new System.Drawing.Point(21, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(854, 241);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control Box";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Session";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "End Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Trainer ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(499, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Name";
            // 
            // enrollBtn
            // 
            this.enrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrollBtn.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.enrollBtn.Location = new System.Drawing.Point(783, 518);
            this.enrollBtn.Name = "enrollBtn";
            this.enrollBtn.Size = new System.Drawing.Size(92, 35);
            this.enrollBtn.TabIndex = 3;
            this.enrollBtn.Text = "Enroll";
            this.enrollBtn.UseVisualStyleBackColor = true;
            this.enrollBtn.Click += new System.EventHandler(this.enrollBtn_Click);
            // 
            // classIDLbl
            // 
            this.classIDLbl.AutoSize = true;
            this.classIDLbl.Location = new System.Drawing.Point(230, 33);
            this.classIDLbl.Name = "classIDLbl";
            this.classIDLbl.Size = new System.Drawing.Size(0, 19);
            this.classIDLbl.TabIndex = 8;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(230, 86);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(0, 19);
            this.titleLbl.TabIndex = 9;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(230, 138);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(0, 19);
            this.categoryLbl.TabIndex = 10;
            // 
            // nosLbl
            // 
            this.nosLbl.AutoSize = true;
            this.nosLbl.Location = new System.Drawing.Point(230, 191);
            this.nosLbl.Name = "nosLbl";
            this.nosLbl.Size = new System.Drawing.Size(0, 19);
            this.nosLbl.TabIndex = 11;
            // 
            // startDateLbl
            // 
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Location = new System.Drawing.Point(593, 33);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(0, 19);
            this.startDateLbl.TabIndex = 12;
            // 
            // endDateLbl
            // 
            this.endDateLbl.AutoSize = true;
            this.endDateLbl.Location = new System.Drawing.Point(593, 86);
            this.endDateLbl.Name = "endDateLbl";
            this.endDateLbl.Size = new System.Drawing.Size(0, 19);
            this.endDateLbl.TabIndex = 13;
            // 
            // trainerIDLbl
            // 
            this.trainerIDLbl.AutoSize = true;
            this.trainerIDLbl.Location = new System.Drawing.Point(593, 138);
            this.trainerIDLbl.Name = "trainerIDLbl";
            this.trainerIDLbl.Size = new System.Drawing.Size(0, 19);
            this.trainerIDLbl.TabIndex = 14;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(593, 191);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(0, 19);
            this.nameLbl.TabIndex = 15;
            // 
            // memberClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(893, 570);
            this.Controls.Add(this.enrollBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "memberClass";
            this.Text = "memeberClass";
            this.Load += new System.EventHandler(this.memberClass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView classDataGridView;
        private System.Windows.Forms.DataGridView trainerDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enrollBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label trainerIDLbl;
        private System.Windows.Forms.Label endDateLbl;
        private System.Windows.Forms.Label startDateLbl;
        private System.Windows.Forms.Label nosLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label classIDLbl;
    }
}