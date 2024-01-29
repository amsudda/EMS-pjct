namespace Project_1
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.PWlbl = new System.Windows.Forms.Label();
            this.usernmlbl = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearbtn);
            this.groupBox1.Controls.Add(this.loginbtn);
            this.groupBox1.Controls.Add(this.PWlbl);
            this.groupBox1.Controls.Add(this.usernmlbl);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(33, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearbtn.Location = new System.Drawing.Point(46, 264);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(120, 23);
            this.clearbtn.TabIndex = 2;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbtn.Location = new System.Drawing.Point(46, 225);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(120, 23);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // PWlbl
            // 
            this.PWlbl.AutoSize = true;
            this.PWlbl.Location = new System.Drawing.Point(13, 155);
            this.PWlbl.Name = "PWlbl";
            this.PWlbl.Size = new System.Drawing.Size(53, 13);
            this.PWlbl.TabIndex = 1;
            this.PWlbl.Text = "Password";
            // 
            // usernmlbl
            // 
            this.usernmlbl.AutoSize = true;
            this.usernmlbl.Location = new System.Drawing.Point(13, 66);
            this.usernmlbl.Name = "usernmlbl";
            this.usernmlbl.Size = new System.Drawing.Size(55, 13);
            this.usernmlbl.TabIndex = 1;
            this.usernmlbl.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(16, 181);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(202, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(16, 91);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(202, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbtn.Location = new System.Drawing.Point(12, 420);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(69, 23);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Skills international";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login form";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label PWlbl;
        private System.Windows.Forms.Label usernmlbl;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label label1;
    }
}

