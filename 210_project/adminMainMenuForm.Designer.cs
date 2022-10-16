namespace _210_project
{
    partial class formAdminMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdminMainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.enrollmentBtn = new System.Windows.Forms.Button();
            this.trainerBtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.classBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.enrollmentBtn);
            this.panel1.Controls.Add(this.trainerBtn);
            this.panel1.Controls.Add(this.userBtn);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.classBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 560);
            this.panel1.TabIndex = 0;
            // 
            // enrollmentBtn
            // 
            this.enrollmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.enrollmentBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.enrollmentBtn.FlatAppearance.BorderSize = 2;
            this.enrollmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrollmentBtn.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollmentBtn.ForeColor = System.Drawing.Color.Black;
            this.enrollmentBtn.Location = new System.Drawing.Point(0, 247);
            this.enrollmentBtn.Name = "enrollmentBtn";
            this.enrollmentBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.enrollmentBtn.Size = new System.Drawing.Size(181, 50);
            this.enrollmentBtn.TabIndex = 6;
            this.enrollmentBtn.Text = "Enrollment Data";
            this.enrollmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enrollmentBtn.UseVisualStyleBackColor = false;
            this.enrollmentBtn.Click += new System.EventHandler(this.enrollmentBtn_Click);
            // 
            // trainerBtn
            // 
            this.trainerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.trainerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.trainerBtn.FlatAppearance.BorderSize = 2;
            this.trainerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainerBtn.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerBtn.ForeColor = System.Drawing.Color.Black;
            this.trainerBtn.Location = new System.Drawing.Point(0, 197);
            this.trainerBtn.Name = "trainerBtn";
            this.trainerBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.trainerBtn.Size = new System.Drawing.Size(181, 50);
            this.trainerBtn.TabIndex = 5;
            this.trainerBtn.Text = "Trainers";
            this.trainerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trainerBtn.UseVisualStyleBackColor = false;
            this.trainerBtn.Click += new System.EventHandler(this.trainerBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userBtn.FlatAppearance.BorderSize = 2;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.Black;
            this.userBtn.Location = new System.Drawing.Point(0, 147);
            this.userBtn.Name = "userBtn";
            this.userBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.userBtn.Size = new System.Drawing.Size(181, 50);
            this.userBtn.TabIndex = 4;
            this.userBtn.Text = "Users";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.UseVisualStyleBackColor = false;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.logOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOutBtn.Location = new System.Drawing.Point(0, 518);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(181, 42);
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // classBtn
            // 
            this.classBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.classBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.classBtn.FlatAppearance.BorderSize = 2;
            this.classBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classBtn.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classBtn.ForeColor = System.Drawing.Color.Black;
            this.classBtn.Location = new System.Drawing.Point(0, 97);
            this.classBtn.Name = "classBtn";
            this.classBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.classBtn.Size = new System.Drawing.Size(181, 50);
            this.classBtn.TabIndex = 3;
            this.classBtn.Text = "Gym Classes";
            this.classBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classBtn.UseVisualStyleBackColor = false;
            this.classBtn.Click += new System.EventHandler(this.classBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 97);
            this.panel3.TabIndex = 2;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(181, 0);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(760, 560);
            this.childFormPanel.TabIndex = 2;
            // 
            // formAdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 560);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formAdminMainMenu";
            this.Text = "Main Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button classBtn;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button enrollmentBtn;
        private System.Windows.Forms.Button trainerBtn;
    }
}