namespace _210_project
{
    partial class userChangePassword
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
            this.oldPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassTxtBox = new System.Windows.Forms.TextBox();
            this.newPassTxtBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oldErrorLbl = new System.Windows.Forms.Label();
            this.newErrorLbl = new System.Windows.Forms.Label();
            this.new2ErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(106, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // oldPasswordTxtBox
            // 
            this.oldPasswordTxtBox.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordTxtBox.Location = new System.Drawing.Point(266, 86);
            this.oldPasswordTxtBox.Name = "oldPasswordTxtBox";
            this.oldPasswordTxtBox.Size = new System.Drawing.Size(162, 25);
            this.oldPasswordTxtBox.TabIndex = 1;
            this.oldPasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.FlatAppearance.BorderSize = 3;
            this.changePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordBtn.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(168)))));
            this.changePasswordBtn.Location = new System.Drawing.Point(334, 262);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(94, 44);
            this.changePasswordBtn.TabIndex = 2;
            this.changePasswordBtn.Text = "Change";
            this.changePasswordBtn.UseVisualStyleBackColor = true;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(251)))));
            this.label2.Location = new System.Drawing.Point(106, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(251)))));
            this.label3.Location = new System.Drawing.Point(25, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re-enter New Password";
            // 
            // newPassTxtBox
            // 
            this.newPassTxtBox.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTxtBox.Location = new System.Drawing.Point(266, 148);
            this.newPassTxtBox.Name = "newPassTxtBox";
            this.newPassTxtBox.Size = new System.Drawing.Size(162, 25);
            this.newPassTxtBox.TabIndex = 5;
            this.newPassTxtBox.TextChanged += new System.EventHandler(this.newPassTxtBox_TextChanged);
            // 
            // newPassTxtBox2
            // 
            this.newPassTxtBox2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTxtBox2.Location = new System.Drawing.Point(266, 208);
            this.newPassTxtBox2.Name = "newPassTxtBox2";
            this.newPassTxtBox2.Size = new System.Drawing.Size(162, 25);
            this.newPassTxtBox2.TabIndex = 6;
            this.newPassTxtBox2.TextChanged += new System.EventHandler(this.newPassTxtBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(161, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Change Password";
            // 
            // oldErrorLbl
            // 
            this.oldErrorLbl.AutoSize = true;
            this.oldErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.oldErrorLbl.Location = new System.Drawing.Point(264, 120);
            this.oldErrorLbl.Name = "oldErrorLbl";
            this.oldErrorLbl.Size = new System.Drawing.Size(0, 16);
            this.oldErrorLbl.TabIndex = 8;
            // 
            // newErrorLbl
            // 
            this.newErrorLbl.AutoSize = true;
            this.newErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.newErrorLbl.Location = new System.Drawing.Point(265, 181);
            this.newErrorLbl.Name = "newErrorLbl";
            this.newErrorLbl.Size = new System.Drawing.Size(0, 16);
            this.newErrorLbl.TabIndex = 9;
            // 
            // new2ErrorLbl
            // 
            this.new2ErrorLbl.AutoSize = true;
            this.new2ErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.new2ErrorLbl.Location = new System.Drawing.Point(264, 240);
            this.new2ErrorLbl.Name = "new2ErrorLbl";
            this.new2ErrorLbl.Size = new System.Drawing.Size(0, 16);
            this.new2ErrorLbl.TabIndex = 10;
            // 
            // userChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(482, 334);
            this.Controls.Add(this.new2ErrorLbl);
            this.Controls.Add(this.newErrorLbl);
            this.Controls.Add(this.oldErrorLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPassTxtBox2);
            this.Controls.Add(this.newPassTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.oldPasswordTxtBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "userChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPasswordTxtBox;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPassTxtBox;
        private System.Windows.Forms.TextBox newPassTxtBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label oldErrorLbl;
        private System.Windows.Forms.Label newErrorLbl;
        private System.Windows.Forms.Label new2ErrorLbl;
    }
}