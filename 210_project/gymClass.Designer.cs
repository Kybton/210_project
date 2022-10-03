namespace _210_project
{
    partial class gymClass
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
            this.gymClassesDataGridView = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.classIDLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.categoryTxtBox = new System.Windows.Forms.TextBox();
            this.nosTxtBox = new System.Windows.Forms.TextBox();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchByComBox = new System.Windows.Forms.ComboBox();
            this.searchRequiredLbl = new System.Windows.Forms.Label();
            this.titleRequiredLbl = new System.Windows.Forms.Label();
            this.categoryRequiredLbl = new System.Windows.Forms.Label();
            this.nosRequiredLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gymClassesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gymClassesDataGridView
            // 
            this.gymClassesDataGridView.AllowUserToAddRows = false;
            this.gymClassesDataGridView.AllowUserToDeleteRows = false;
            this.gymClassesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gymClassesDataGridView.Location = new System.Drawing.Point(34, 12);
            this.gymClassesDataGridView.Name = "gymClassesDataGridView";
            this.gymClassesDataGridView.ReadOnly = true;
            this.gymClassesDataGridView.RowHeadersWidth = 51;
            this.gymClassesDataGridView.RowTemplate.Height = 24;
            this.gymClassesDataGridView.Size = new System.Drawing.Size(757, 150);
            this.gymClassesDataGridView.TabIndex = 0;
            this.gymClassesDataGridView.Click += new System.EventHandler(this.gymClassesDataGridView_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(184, 476);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(81, 35);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of Session";
            // 
            // classIDLbl
            // 
            this.classIDLbl.AutoSize = true;
            this.classIDLbl.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classIDLbl.ForeColor = System.Drawing.Color.White;
            this.classIDLbl.Location = new System.Drawing.Point(110, 200);
            this.classIDLbl.Name = "classIDLbl";
            this.classIDLbl.Size = new System.Drawing.Size(0, 20);
            this.classIDLbl.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "End Date";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxtBox.Location = new System.Drawing.Point(184, 235);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(153, 26);
            this.titleTxtBox.TabIndex = 9;
            // 
            // categoryTxtBox
            // 
            this.categoryTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTxtBox.Location = new System.Drawing.Point(184, 280);
            this.categoryTxtBox.Name = "categoryTxtBox";
            this.categoryTxtBox.Size = new System.Drawing.Size(153, 26);
            this.categoryTxtBox.TabIndex = 10;
            // 
            // nosTxtBox
            // 
            this.nosTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosTxtBox.Location = new System.Drawing.Point(184, 330);
            this.nosTxtBox.Name = "nosTxtBox";
            this.nosTxtBox.Size = new System.Drawing.Size(153, 26);
            this.nosTxtBox.TabIndex = 11;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(535, 235);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(153, 26);
            this.searchTxtBox.TabIndex = 14;
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(709, 227);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(81, 34);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.Location = new System.Drawing.Point(184, 382);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(234, 26);
            this.startDateTimePicker.TabIndex = 16;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Location = new System.Drawing.Point(184, 428);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(234, 26);
            this.endDateTimePicker.TabIndex = 17;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(412, 476);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(127, 35);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Add New";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(297, 476);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(81, 35);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchByComBox
            // 
            this.searchByComBox.FormattingEnabled = true;
            this.searchByComBox.Items.AddRange(new object[] {
            "Class ID",
            "Title",
            "Category",
            "Session"});
            this.searchByComBox.Location = new System.Drawing.Point(567, 196);
            this.searchByComBox.Name = "searchByComBox";
            this.searchByComBox.Size = new System.Drawing.Size(121, 24);
            this.searchByComBox.TabIndex = 20;
            // 
            // searchRequiredLbl
            // 
            this.searchRequiredLbl.AutoSize = true;
            this.searchRequiredLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRequiredLbl.ForeColor = System.Drawing.Color.Red;
            this.searchRequiredLbl.Location = new System.Drawing.Point(539, 269);
            this.searchRequiredLbl.Name = "searchRequiredLbl";
            this.searchRequiredLbl.Size = new System.Drawing.Size(0, 18);
            this.searchRequiredLbl.TabIndex = 21;
            // 
            // titleRequiredLbl
            // 
            this.titleRequiredLbl.AutoSize = true;
            this.titleRequiredLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleRequiredLbl.ForeColor = System.Drawing.Color.Red;
            this.titleRequiredLbl.Location = new System.Drawing.Point(343, 239);
            this.titleRequiredLbl.Name = "titleRequiredLbl";
            this.titleRequiredLbl.Size = new System.Drawing.Size(0, 18);
            this.titleRequiredLbl.TabIndex = 22;
            // 
            // categoryRequiredLbl
            // 
            this.categoryRequiredLbl.AutoSize = true;
            this.categoryRequiredLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryRequiredLbl.ForeColor = System.Drawing.Color.Red;
            this.categoryRequiredLbl.Location = new System.Drawing.Point(343, 284);
            this.categoryRequiredLbl.Name = "categoryRequiredLbl";
            this.categoryRequiredLbl.Size = new System.Drawing.Size(0, 18);
            this.categoryRequiredLbl.TabIndex = 23;
            // 
            // nosRequiredLbl
            // 
            this.nosRequiredLbl.AutoSize = true;
            this.nosRequiredLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosRequiredLbl.ForeColor = System.Drawing.Color.Red;
            this.nosRequiredLbl.Location = new System.Drawing.Point(343, 334);
            this.nosRequiredLbl.Name = "nosRequiredLbl";
            this.nosRequiredLbl.Size = new System.Drawing.Size(0, 18);
            this.nosRequiredLbl.TabIndex = 24;
            // 
            // gymClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(818, 546);
            this.Controls.Add(this.nosRequiredLbl);
            this.Controls.Add(this.categoryRequiredLbl);
            this.Controls.Add(this.titleRequiredLbl);
            this.Controls.Add(this.searchRequiredLbl);
            this.Controls.Add(this.searchByComBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.nosTxtBox);
            this.Controls.Add(this.categoryTxtBox);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.classIDLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.gymClassesDataGridView);
            this.Name = "gymClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gymClass";
            this.Load += new System.EventHandler(this.gymClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gymClassesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gymClassesDataGridView;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label classIDLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.TextBox categoryTxtBox;
        private System.Windows.Forms.TextBox nosTxtBox;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox searchByComBox;
        private System.Windows.Forms.Label searchRequiredLbl;
        private System.Windows.Forms.Label titleRequiredLbl;
        private System.Windows.Forms.Label categoryRequiredLbl;
        private System.Windows.Forms.Label nosRequiredLbl;
    }
}