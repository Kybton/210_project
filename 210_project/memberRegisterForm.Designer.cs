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
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.Location = new System.Drawing.Point(179, 111);
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
            this.userIdLbl.Location = new System.Drawing.Point(176, 78);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(75, 18);
            this.userIdLbl.TabIndex = 1;
            this.userIdLbl.Text = "User ID: ";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(177, 182);
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
            this.label2.Location = new System.Drawing.Point(103, 121);
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
            this.label3.Location = new System.Drawing.Point(78, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // passwordStrLbl
            // 
            this.passwordStrLbl.AutoSize = true;
            this.passwordStrLbl.Location = new System.Drawing.Point(176, 231);
            this.passwordStrLbl.Name = "passwordStrLbl";
            this.passwordStrLbl.Size = new System.Drawing.Size(0, 16);
            this.passwordStrLbl.TabIndex = 5;
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.Black;
            this.signUpBtn.Location = new System.Drawing.Point(286, 266);
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
            this.passwordHideBtn.Location = new System.Drawing.Point(335, 182);
            this.passwordHideBtn.Name = "passwordHideBtn";
            this.passwordHideBtn.Size = new System.Drawing.Size(41, 34);
            this.passwordHideBtn.TabIndex = 7;
            this.passwordHideBtn.UseVisualStyleBackColor = true;
            this.passwordHideBtn.Click += new System.EventHandler(this.passwordHideBtn_Click);
            // 
            // passwordShowBtn
            // 
            this.passwordShowBtn.Image = ((System.Drawing.Image)(resources.GetObject("passwordShowBtn.Image")));
            this.passwordShowBtn.Location = new System.Drawing.Point(335, 182);
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
            this.nameErrorLbl.Location = new System.Drawing.Point(182, 154);
            this.nameErrorLbl.Name = "nameErrorLbl";
            this.nameErrorLbl.Size = new System.Drawing.Size(0, 16);
            this.nameErrorLbl.TabIndex = 9;
            // 
            // memberRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(494, 392);
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
    }
}