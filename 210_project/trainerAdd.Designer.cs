namespace _210_project
{
    partial class trainerAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.genderComBox = new System.Windows.Forms.ComboBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.trainerIDLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameRequiredLbl = new System.Windows.Forms.Label();
            this.genderRequiredLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(162, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Trainer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(251)))));
            this.label2.Location = new System.Drawing.Point(117, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trainer ID:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(215, 157);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(149, 22);
            this.nameTxtBox.TabIndex = 2;
            // 
            // genderComBox
            // 
            this.genderComBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComBox.FormattingEnabled = true;
            this.genderComBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComBox.Location = new System.Drawing.Point(215, 211);
            this.genderComBox.Name = "genderComBox";
            this.genderComBox.Size = new System.Drawing.Size(149, 28);
            this.genderComBox.TabIndex = 3;
            // 
            // insertBtn
            // 
            this.insertBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.insertBtn.Location = new System.Drawing.Point(274, 295);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(90, 33);
            this.insertBtn.TabIndex = 13;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // trainerIDLbl
            // 
            this.trainerIDLbl.AutoSize = true;
            this.trainerIDLbl.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(251)))));
            this.trainerIDLbl.Location = new System.Drawing.Point(211, 107);
            this.trainerIDLbl.Name = "trainerIDLbl";
            this.trainerIDLbl.Size = new System.Drawing.Size(28, 19);
            this.trainerIDLbl.TabIndex = 14;
            this.trainerIDLbl.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(251)))));
            this.label3.Location = new System.Drawing.Point(135, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(251)))));
            this.label4.Location = new System.Drawing.Point(135, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gender";
            // 
            // nameRequiredLbl
            // 
            this.nameRequiredLbl.AutoSize = true;
            this.nameRequiredLbl.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameRequiredLbl.ForeColor = System.Drawing.Color.Red;
            this.nameRequiredLbl.Location = new System.Drawing.Point(379, 161);
            this.nameRequiredLbl.Name = "nameRequiredLbl";
            this.nameRequiredLbl.Size = new System.Drawing.Size(0, 19);
            this.nameRequiredLbl.TabIndex = 17;
            // 
            // genderRequiredLbl
            // 
            this.genderRequiredLbl.AutoSize = true;
            this.genderRequiredLbl.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderRequiredLbl.ForeColor = System.Drawing.Color.Red;
            this.genderRequiredLbl.Location = new System.Drawing.Point(379, 215);
            this.genderRequiredLbl.Name = "genderRequiredLbl";
            this.genderRequiredLbl.Size = new System.Drawing.Size(0, 19);
            this.genderRequiredLbl.TabIndex = 18;
            // 
            // trainerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(517, 388);
            this.Controls.Add(this.genderRequiredLbl);
            this.Controls.Add(this.nameRequiredLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trainerIDLbl);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.genderComBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "trainerAdd";
            this.ShowIcon = false;
            this.Text = "Add Trainer";
            this.Load += new System.EventHandler(this.trainerAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.ComboBox genderComBox;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label trainerIDLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameRequiredLbl;
        private System.Windows.Forms.Label genderRequiredLbl;
    }
}