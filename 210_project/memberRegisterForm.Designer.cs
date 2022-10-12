namespace _210_project
{
    partial class memberRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memberRegisterForm));
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.userIdLbl = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordStrLbl = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.passwordHideBtn = new System.Windows.Forms.Button();
            this.passwordShowBtn = new System.Windows.Forms.Button();
            this.nameErrorLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.weightTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.heightTxtBox = new System.Windows.Forms.TextBox();
            this.genderComBox = new System.Windows.Forms.ComboBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.phoneErrorLbl = new System.Windows.Forms.Label();
            this.dobErrorLbl = new System.Windows.Forms.Label();
            this.addressErrorLbl = new System.Windows.Forms.Label();
            this.genderErrorLbl = new System.Windows.Forms.Label();
            this.weightErrorLbl = new System.Windows.Forms.Label();
            this.heightErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.Location = new System.Drawing.Point(185, 96);
            this.nameTxtBox.Multiline = true;
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(197, 30);
            this.nameTxtBox.TabIndex = 0;
            this.nameTxtBox.TextChanged += new System.EventHandler(this.nameTxtBox_TextChanged);
            // 
            // userIdLbl
            // 
            this.userIdLbl.AutoSize = true;
            this.userIdLbl.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.userIdLbl.Location = new System.Drawing.Point(182, 63);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(75, 18);
            this.userIdLbl.TabIndex = 1;
            this.userIdLbl.Text = "User ID: ";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(185, 167);
            this.passwordTxtBox.Multiline = true;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(199, 34);
            this.passwordTxtBox.TabIndex = 2;
            this.passwordTxtBox.TextChanged += new System.EventHandler(this.passwordTxtBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // passwordStrLbl
            // 
            this.passwordStrLbl.AutoSize = true;
            this.passwordStrLbl.Location = new System.Drawing.Point(189, 211);
            this.passwordStrLbl.Name = "passwordStrLbl";
            this.passwordStrLbl.Size = new System.Drawing.Size(0, 16);
            this.passwordStrLbl.TabIndex = 5;
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.Black;
            this.signUpBtn.Location = new System.Drawing.Point(392, 586);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(90, 37);
            this.signUpBtn.TabIndex = 6;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // passwordHideBtn
            // 
            this.passwordHideBtn.Image = ((System.Drawing.Image)(resources.GetObject("passwordHideBtn.Image")));
            this.passwordHideBtn.Location = new System.Drawing.Point(343, 167);
            this.passwordHideBtn.Name = "passwordHideBtn";
            this.passwordHideBtn.Size = new System.Drawing.Size(41, 34);
            this.passwordHideBtn.TabIndex = 7;
            this.passwordHideBtn.UseVisualStyleBackColor = true;
            this.passwordHideBtn.Click += new System.EventHandler(this.passwordHideBtn_Click);
            // 
            // passwordShowBtn
            // 
            this.passwordShowBtn.Image = ((System.Drawing.Image)(resources.GetObject("passwordShowBtn.Image")));
            this.passwordShowBtn.Location = new System.Drawing.Point(343, 167);
            this.passwordShowBtn.Name = "passwordShowBtn";
            this.passwordShowBtn.Size = new System.Drawing.Size(41, 34);
            this.passwordShowBtn.TabIndex = 8;
            this.passwordShowBtn.UseVisualStyleBackColor = true;
            this.passwordShowBtn.Click += new System.EventHandler(this.passwordShowBtn_Click);
            // 
            // nameErrorLbl
            // 
            this.nameErrorLbl.AutoSize = true;
            this.nameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLbl.Location = new System.Drawing.Point(187, 133);
            this.nameErrorLbl.Name = "nameErrorLbl";
            this.nameErrorLbl.Size = new System.Drawing.Size(0, 16);
            this.nameErrorLbl.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sign Up";
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxtBox.Location = new System.Drawing.Point(185, 236);
            this.phoneTxtBox.Multiline = true;
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(197, 30);
            this.phoneTxtBox.TabIndex = 11;
            this.phoneTxtBox.Leave += new System.EventHandler(this.phoneTxtBox_Leave);
            // 
            // weightTxtBox
            // 
            this.weightTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTxtBox.Location = new System.Drawing.Point(185, 478);
            this.weightTxtBox.Multiline = true;
            this.weightTxtBox.Name = "weightTxtBox";
            this.weightTxtBox.Size = new System.Drawing.Size(146, 30);
            this.weightTxtBox.TabIndex = 12;
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxtBox.Location = new System.Drawing.Point(185, 358);
            this.addressTxtBox.Multiline = true;
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(197, 30);
            this.addressTxtBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(108, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(60, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(93, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Address";
            // 
            // heightTxtBox
            // 
            this.heightTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightTxtBox.Location = new System.Drawing.Point(185, 542);
            this.heightTxtBox.Multiline = true;
            this.heightTxtBox.Name = "heightTxtBox";
            this.heightTxtBox.Size = new System.Drawing.Size(146, 30);
            this.heightTxtBox.TabIndex = 17;
            // 
            // genderComBox
            // 
            this.genderComBox.FormattingEnabled = true;
            this.genderComBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComBox.Location = new System.Drawing.Point(185, 418);
            this.genderComBox.Name = "genderComBox";
            this.genderComBox.Size = new System.Drawing.Size(121, 24);
            this.genderComBox.TabIndex = 18;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Location = new System.Drawing.Point(185, 303);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dobDateTimePicker.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(93, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(98, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Weight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(98, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Height";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(339, 482);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "kg";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(339, 546);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "cm";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // phoneErrorLbl
            // 
            this.phoneErrorLbl.AutoSize = true;
            this.phoneErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorLbl.Location = new System.Drawing.Point(182, 278);
            this.phoneErrorLbl.Name = "phoneErrorLbl";
            this.phoneErrorLbl.Size = new System.Drawing.Size(0, 16);
            this.phoneErrorLbl.TabIndex = 25;
            // 
            // dobErrorLbl
            // 
            this.dobErrorLbl.AutoSize = true;
            this.dobErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.dobErrorLbl.Location = new System.Drawing.Point(185, 331);
            this.dobErrorLbl.Name = "dobErrorLbl";
            this.dobErrorLbl.Size = new System.Drawing.Size(0, 16);
            this.dobErrorLbl.TabIndex = 26;
            // 
            // addressErrorLbl
            // 
            this.addressErrorLbl.AutoSize = true;
            this.addressErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.addressErrorLbl.Location = new System.Drawing.Point(185, 395);
            this.addressErrorLbl.Name = "addressErrorLbl";
            this.addressErrorLbl.Size = new System.Drawing.Size(0, 16);
            this.addressErrorLbl.TabIndex = 27;
            // 
            // genderErrorLbl
            // 
            this.genderErrorLbl.AutoSize = true;
            this.genderErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.genderErrorLbl.Location = new System.Drawing.Point(187, 452);
            this.genderErrorLbl.Name = "genderErrorLbl";
            this.genderErrorLbl.Size = new System.Drawing.Size(0, 16);
            this.genderErrorLbl.TabIndex = 28;
            // 
            // weightErrorLbl
            // 
            this.weightErrorLbl.AutoSize = true;
            this.weightErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.weightErrorLbl.Location = new System.Drawing.Point(187, 515);
            this.weightErrorLbl.Name = "weightErrorLbl";
            this.weightErrorLbl.Size = new System.Drawing.Size(0, 16);
            this.weightErrorLbl.TabIndex = 29;
            // 
            // heightErrorLbl
            // 
            this.heightErrorLbl.AutoSize = true;
            this.heightErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.heightErrorLbl.Location = new System.Drawing.Point(187, 582);
            this.heightErrorLbl.Name = "heightErrorLbl";
            this.heightErrorLbl.Size = new System.Drawing.Size(0, 16);
            this.heightErrorLbl.TabIndex = 30;
            // 
            // memberRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(494, 635);
            this.Controls.Add(this.heightErrorLbl);
            this.Controls.Add(this.weightErrorLbl);
            this.Controls.Add(this.genderErrorLbl);
            this.Controls.Add(this.addressErrorLbl);
            this.Controls.Add(this.dobErrorLbl);
            this.Controls.Add(this.phoneErrorLbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.genderComBox);
            this.Controls.Add(this.heightTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.weightTxtBox);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameErrorLbl);
            this.Controls.Add(this.passwordShowBtn);
            this.Controls.Add(this.passwordHideBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.passwordStrLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.userIdLbl);
            this.Controls.Add(this.nameTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "memberRegisterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label userIdLbl;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label passwordStrLbl;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button passwordHideBtn;
        private System.Windows.Forms.Button passwordShowBtn;
        private System.Windows.Forms.Label nameErrorLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.TextBox weightTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox heightTxtBox;
        private System.Windows.Forms.ComboBox genderComBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label phoneErrorLbl;
        private System.Windows.Forms.Label dobErrorLbl;
        private System.Windows.Forms.Label addressErrorLbl;
        private System.Windows.Forms.Label genderErrorLbl;
        private System.Windows.Forms.Label weightErrorLbl;
        private System.Windows.Forms.Label heightErrorLbl;
    }
}