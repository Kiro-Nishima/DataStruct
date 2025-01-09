namespace DataStruct
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            panelHolder = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            logInHolder = new Panel();
            lbCreateAccount = new LinkLabel();
            btnLogIn = new Button();
            label3 = new Label();
            label2 = new Label();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            label1 = new Label();
            panelHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            logInHolder.SuspendLayout();
            SuspendLayout();
            // 
            // panelHolder
            // 
            panelHolder.BackColor = Color.DarkRed;
            panelHolder.Controls.Add(pictureBox1);
            panelHolder.Controls.Add(label4);
            panelHolder.Controls.Add(logInHolder);
            panelHolder.Dock = DockStyle.Fill;
            panelHolder.Location = new Point(0, 0);
            panelHolder.Name = "panelHolder";
            panelHolder.Size = new Size(1130, 625);
            panelHolder.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(59, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 402);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(67, 57);
            label4.Name = "label4";
            label4.Size = new Size(325, 56);
            label4.TabIndex = 2;
            label4.Text = "WELCOME TO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logInHolder
            // 
            logInHolder.BackColor = Color.FromArgb(64, 0, 0);
            logInHolder.Controls.Add(lbCreateAccount);
            logInHolder.Controls.Add(btnLogIn);
            logInHolder.Controls.Add(label3);
            logInHolder.Controls.Add(label2);
            logInHolder.Controls.Add(tbPassword);
            logInHolder.Controls.Add(tbUsername);
            logInHolder.Controls.Add(label1);
            logInHolder.Dock = DockStyle.Right;
            logInHolder.Location = new Point(461, 0);
            logInHolder.Name = "logInHolder";
            logInHolder.Size = new Size(669, 625);
            logInHolder.TabIndex = 0;
            // 
            // lbCreateAccount
            // 
            lbCreateAccount.ActiveLinkColor = Color.White;
            lbCreateAccount.AutoSize = true;
            lbCreateAccount.DisabledLinkColor = Color.Gray;
            lbCreateAccount.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCreateAccount.LinkColor = Color.White;
            lbCreateAccount.Location = new Point(273, 560);
            lbCreateAccount.Name = "lbCreateAccount";
            lbCreateAccount.Size = new Size(167, 21);
            lbCreateAccount.TabIndex = 4;
            lbCreateAccount.TabStop = true;
            lbCreateAccount.Text = "Create An Account";
            lbCreateAccount.VisitedLinkColor = Color.FromArgb(255, 192, 192);
            // 
            // btnLogIn
            // 
            btnLogIn.FlatAppearance.BorderSize = 2;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(145, 416);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(400, 46);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "LOG IN";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(142, 238);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(142, 171);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.White;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(145, 255);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(400, 26);
            tbPassword.TabIndex = 1;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.White;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(145, 188);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(400, 26);
            tbUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(256, 29);
            label1.Name = "label1";
            label1.Size = new Size(184, 56);
            label1.TabIndex = 0;
            label1.Text = "LOG IN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1130, 625);
            Controls.Add(panelHolder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelHolder.ResumeLayout(false);
            panelHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            logInHolder.ResumeLayout(false);
            logInHolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHolder;
        private Panel logInHolder;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label label1;
        private LinkLabel lbCreateAccount;
        private Button btnLogIn;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
