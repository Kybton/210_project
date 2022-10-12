namespace _210_project
{
    partial class memberMainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.eDataBtn = new System.Windows.Forms.Button();
            this.classesBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.eDataBtn);
            this.panel1.Controls.Add(this.classesBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 617);
            this.panel1.TabIndex = 0;
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.profileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.Black;
            this.profileBtn.Location = new System.Drawing.Point(0, 257);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(188, 58);
            this.profileBtn.TabIndex = 4;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(124)))), ((int)(((byte)(88)))));
            this.logOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.Black;
            this.logOutBtn.Location = new System.Drawing.Point(0, 559);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(188, 58);
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // eDataBtn
            // 
            this.eDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.eDataBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.eDataBtn.FlatAppearance.BorderSize = 0;
            this.eDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eDataBtn.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDataBtn.ForeColor = System.Drawing.Color.Black;
            this.eDataBtn.Location = new System.Drawing.Point(0, 199);
            this.eDataBtn.Name = "eDataBtn";
            this.eDataBtn.Size = new System.Drawing.Size(188, 58);
            this.eDataBtn.TabIndex = 2;
            this.eDataBtn.Text = "Enrollment Data";
            this.eDataBtn.UseVisualStyleBackColor = false;
            this.eDataBtn.Click += new System.EventHandler(this.eDataBtn_Click);
            // 
            // classesBtn
            // 
            this.classesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.classesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.classesBtn.FlatAppearance.BorderSize = 0;
            this.classesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classesBtn.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classesBtn.ForeColor = System.Drawing.Color.Black;
            this.classesBtn.Location = new System.Drawing.Point(0, 141);
            this.classesBtn.Name = "classesBtn";
            this.classesBtn.Size = new System.Drawing.Size(188, 58);
            this.classesBtn.TabIndex = 1;
            this.classesBtn.Text = "Classes";
            this.classesBtn.UseVisualStyleBackColor = false;
            this.classesBtn.Click += new System.EventHandler(this.classesBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 141);
            this.panel3.TabIndex = 0;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(188, 0);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(911, 617);
            this.childFormPanel.TabIndex = 1;
            // 
            // memberMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 617);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "memberMainMenu";
            this.Text = "Main Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Button classesBtn;
        private System.Windows.Forms.Button eDataBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button profileBtn;
    }
}