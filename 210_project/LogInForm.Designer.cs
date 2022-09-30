namespace _210_project
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginBtn = new System.Windows.Forms.Button();
            this.memberRdBtn = new System.Windows.Forms.RadioButton();
            this.adminRdBtn = new System.Windows.Forms.RadioButton();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.usernameErrorLbl = new System.Windows.Forms.Label();
            this.passwordErrorLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.showPCheckBox = new System.Windows.Forms.CheckBox();
            this.roleErrorLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(63)))), ((int)(((byte)(123)))));
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(63)))), ((int)(((byte)(123)))));
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(104)))), ((int)(((byte)(160)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(588, 368);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(163, 49);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // memberRdBtn
            // 
            this.memberRdBtn.AutoSize = true;
            this.memberRdBtn.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberRdBtn.ForeColor = System.Drawing.Color.White;
            this.memberRdBtn.Location = new System.Drawing.Point(566, 102);
            this.memberRdBtn.Name = "memberRdBtn";
            this.memberRdBtn.Size = new System.Drawing.Size(87, 21);
            this.memberRdBtn.TabIndex = 1;
            this.memberRdBtn.TabStop = true;
            this.memberRdBtn.Text = "Member";
            this.memberRdBtn.UseVisualStyleBackColor = true;
            // 
            // adminRdBtn
            // 
            this.adminRdBtn.AutoSize = true;
            this.adminRdBtn.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRdBtn.ForeColor = System.Drawing.Color.White;
            this.adminRdBtn.Location = new System.Drawing.Point(670, 102);
            this.adminRdBtn.Name = "adminRdBtn";
            this.adminRdBtn.Size = new System.Drawing.Size(75, 21);
            this.adminRdBtn.TabIndex = 2;
            this.adminRdBtn.TabStop = true;
            this.adminRdBtn.Text = "Admin";
            this.adminRdBtn.UseVisualStyleBackColor = true;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.usernameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxtBox.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(68)))), ((int)(((byte)(57)))));
            this.usernameTxtBox.Location = new System.Drawing.Point(419, 163);
            this.usernameTxtBox.Multiline = true;
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(326, 35);
            this.usernameTxtBox.TabIndex = 5;
            this.usernameTxtBox.Text = "Username";
            this.usernameTxtBox.Enter += new System.EventHandler(this.usernameTxtBox_Enter);
            this.usernameTxtBox.Leave += new System.EventHandler(this.usernameTxtBox_Leave);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.passwordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtBox.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.passwordTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(68)))), ((int)(((byte)(57)))));
            this.passwordTxtBox.Location = new System.Drawing.Point(419, 240);
            this.passwordTxtBox.Multiline = true;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(326, 35);
            this.passwordTxtBox.TabIndex = 6;
            this.passwordTxtBox.Text = "Password";
            this.passwordTxtBox.Enter += new System.EventHandler(this.passwordTxtBox_Enter);
            this.passwordTxtBox.Leave += new System.EventHandler(this.passwordTxtBox_Leave);
            // 
            // usernameErrorLbl
            // 
            this.usernameErrorLbl.AutoSize = true;
            this.usernameErrorLbl.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.usernameErrorLbl.Location = new System.Drawing.Point(423, 206);
            this.usernameErrorLbl.Name = "usernameErrorLbl";
            this.usernameErrorLbl.Size = new System.Drawing.Size(0, 18);
            this.usernameErrorLbl.TabIndex = 11;
            // 
            // passwordErrorLbl
            // 
            this.passwordErrorLbl.AutoSize = true;
            this.passwordErrorLbl.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLbl.Location = new System.Drawing.Point(423, 286);
            this.passwordErrorLbl.Name = "passwordErrorLbl";
            this.passwordErrorLbl.Size = new System.Drawing.Size(0, 18);
            this.passwordErrorLbl.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 465);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(72, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "WELCOME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(541, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "LOGIN";
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(63)))), ((int)(((byte)(123)))));
            this.signUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.signUpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(63)))), ((int)(((byte)(123)))));
            this.signUpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(104)))), ((int)(((byte)(160)))));
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.White;
            this.signUpBtn.Location = new System.Drawing.Point(419, 368);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(163, 49);
            this.signUpBtn.TabIndex = 15;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // showPCheckBox
            // 
            this.showPCheckBox.AutoSize = true;
            this.showPCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.showPCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPCheckBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPCheckBox.ForeColor = System.Drawing.Color.White;
            this.showPCheckBox.Location = new System.Drawing.Point(680, 286);
            this.showPCheckBox.Name = "showPCheckBox";
            this.showPCheckBox.Size = new System.Drawing.Size(65, 24);
            this.showPCheckBox.TabIndex = 16;
            this.showPCheckBox.Text = "Show";
            this.showPCheckBox.UseVisualStyleBackColor = true;
            this.showPCheckBox.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // roleErrorLbl
            // 
            this.roleErrorLbl.AutoSize = true;
            this.roleErrorLbl.Font = new System.Drawing.Font("SimSun", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.roleErrorLbl.Location = new System.Drawing.Point(573, 129);
            this.roleErrorLbl.Name = "roleErrorLbl";
            this.roleErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.roleErrorLbl.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(854, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(814, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.rememberCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rememberCheckBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberCheckBox.ForeColor = System.Drawing.Color.White;
            this.rememberCheckBox.Location = new System.Drawing.Point(419, 316);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(123, 24);
            this.rememberCheckBox.TabIndex = 20;
            this.rememberCheckBox.Text = "Remember Me";
            this.rememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(63)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(888, 465);
            this.Controls.Add(this.rememberCheckBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roleErrorLbl);
            this.Controls.Add(this.showPCheckBox);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passwordErrorLbl);
            this.Controls.Add(this.usernameErrorLbl);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.memberRdBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.adminRdBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.RadioButton memberRdBtn;
        private System.Windows.Forms.RadioButton adminRdBtn;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label usernameErrorLbl;
        private System.Windows.Forms.Label passwordErrorLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.CheckBox showPCheckBox;
        private System.Windows.Forms.Label roleErrorLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox rememberCheckBox;
    }
}

