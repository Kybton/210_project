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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
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
            this.updateBtn.Location = new System.Drawing.Point(157, 476);
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
            this.label1.Location = new System.Drawing.Point(12, 200);
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
            this.label2.Location = new System.Drawing.Point(11, 243);
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
            this.label3.Location = new System.Drawing.Point(12, 288);
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
            this.label4.Location = new System.Drawing.Point(11, 338);
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
            this.classIDLbl.Location = new System.Drawing.Point(83, 200);
            this.classIDLbl.Name = "classIDLbl";
            this.classIDLbl.Size = new System.Drawing.Size(0, 20);
            this.classIDLbl.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 382);
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
            this.label7.Location = new System.Drawing.Point(11, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "End Date";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxtBox.Location = new System.Drawing.Point(157, 235);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(153, 26);
            this.titleTxtBox.TabIndex = 9;
            // 
            // categoryTxtBox
            // 
            this.categoryTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTxtBox.Location = new System.Drawing.Point(157, 280);
            this.categoryTxtBox.Name = "categoryTxtBox";
            this.categoryTxtBox.Size = new System.Drawing.Size(153, 26);
            this.categoryTxtBox.TabIndex = 10;
            // 
            // nosTxtBox
            // 
            this.nosTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosTxtBox.Location = new System.Drawing.Point(157, 330);
            this.nosTxtBox.Name = "nosTxtBox";
            this.nosTxtBox.Size = new System.Drawing.Size(153, 26);
            this.nosTxtBox.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(438, 192);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(153, 26);
            this.textBox6.TabIndex = 14;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(622, 177);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(81, 41);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.Location = new System.Drawing.Point(157, 382);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(234, 26);
            this.startDateTimePicker.TabIndex = 16;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Location = new System.Drawing.Point(157, 428);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(234, 26);
            this.endDateTimePicker.TabIndex = 17;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(425, 419);
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
            this.deleteBtn.Location = new System.Drawing.Point(270, 476);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(81, 35);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // gymClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(818, 546);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.textBox6);
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
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}