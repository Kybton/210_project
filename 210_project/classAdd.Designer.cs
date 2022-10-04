namespace _210_project
{
    partial class classAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.classIDLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.categoryTxtBox = new System.Windows.Forms.TextBox();
            this.nosTxtBox = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.insertBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(201, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class ID: ";
            // 
            // classIDLbl
            // 
            this.classIDLbl.AutoSize = true;
            this.classIDLbl.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(251)))));
            this.classIDLbl.Location = new System.Drawing.Point(301, 91);
            this.classIDLbl.Name = "classIDLbl";
            this.classIDLbl.Size = new System.Drawing.Size(0, 22);
            this.classIDLbl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(196, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add New Class";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.titleTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTxtBox.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(68)))), ((int)(((byte)(57)))));
            this.titleTxtBox.Location = new System.Drawing.Point(205, 135);
            this.titleTxtBox.Multiline = true;
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(251, 29);
            this.titleTxtBox.TabIndex = 6;
            this.titleTxtBox.Text = "Title";
            this.titleTxtBox.Enter += new System.EventHandler(this.titleTxtBox_Enter);
            this.titleTxtBox.Leave += new System.EventHandler(this.titleTxtBox_Leave);
            // 
            // categoryTxtBox
            // 
            this.categoryTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.categoryTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryTxtBox.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(68)))), ((int)(((byte)(57)))));
            this.categoryTxtBox.Location = new System.Drawing.Point(205, 199);
            this.categoryTxtBox.Multiline = true;
            this.categoryTxtBox.Name = "categoryTxtBox";
            this.categoryTxtBox.Size = new System.Drawing.Size(251, 29);
            this.categoryTxtBox.TabIndex = 7;
            this.categoryTxtBox.Text = "Category";
            this.categoryTxtBox.Enter += new System.EventHandler(this.categoryTxtBox_Enter);
            this.categoryTxtBox.Leave += new System.EventHandler(this.categoryTxtBox_Leave);
            // 
            // nosTxtBox
            // 
            this.nosTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.nosTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nosTxtBox.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(68)))), ((int)(((byte)(57)))));
            this.nosTxtBox.Location = new System.Drawing.Point(205, 267);
            this.nosTxtBox.Multiline = true;
            this.nosTxtBox.Name = "nosTxtBox";
            this.nosTxtBox.Size = new System.Drawing.Size(251, 29);
            this.nosTxtBox.TabIndex = 8;
            this.nosTxtBox.Text = "Number of Session";
            this.nosTxtBox.Enter += new System.EventHandler(this.nosTxtBox_Enter);
            this.nosTxtBox.Leave += new System.EventHandler(this.nosTxtBox_Leave);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(205, 338);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(251, 22);
            this.startDateTimePicker.TabIndex = 10;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(205, 405);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(251, 22);
            this.endDateTimePicker.TabIndex = 11;
            // 
            // insertBtn
            // 
            this.insertBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.insertBtn.Location = new System.Drawing.Point(366, 463);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(90, 33);
            this.insertBtn.TabIndex = 12;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // classAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(651, 533);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.nosTxtBox);
            this.Controls.Add(this.categoryTxtBox);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classIDLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "classAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Class";
            this.Load += new System.EventHandler(this.classAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label classIDLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.TextBox categoryTxtBox;
        private System.Windows.Forms.TextBox nosTxtBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button insertBtn;
    }
}