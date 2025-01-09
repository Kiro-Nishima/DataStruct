namespace DataStruct
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            panelHolder = new Panel();
            pictureBox1 = new PictureBox();
            logInHolder = new Panel();
            lbLogIn = new LinkLabel();
            btnCreateAccount = new Button();
            label2 = new Label();
            tbUsername = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label12 = new Label();
            panelHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            logInHolder.SuspendLayout();
            SuspendLayout();
            // 
            // panelHolder
            // 
            panelHolder.BackColor = Color.DarkRed;
            panelHolder.Controls.Add(pictureBox1);
            panelHolder.Controls.Add(logInHolder);
            panelHolder.Controls.Add(label4);
            panelHolder.Dock = DockStyle.Fill;
            panelHolder.Location = new Point(0, 0);
            panelHolder.Name = "panelHolder";
            panelHolder.Size = new Size(1130, 625);
            panelHolder.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(59, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 402);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // logInHolder
            // 
            logInHolder.BackColor = Color.FromArgb(64, 0, 0);
            logInHolder.Controls.Add(dateTimePicker1);
            logInHolder.Controls.Add(lbLogIn);
            logInHolder.Controls.Add(btnCreateAccount);
            logInHolder.Controls.Add(label7);
            logInHolder.Controls.Add(label6);
            logInHolder.Controls.Add(label5);
            logInHolder.Controls.Add(label3);
            logInHolder.Controls.Add(textBox3);
            logInHolder.Controls.Add(textBox2);
            logInHolder.Controls.Add(label12);
            logInHolder.Controls.Add(label11);
            logInHolder.Controls.Add(label10);
            logInHolder.Controls.Add(label2);
            logInHolder.Controls.Add(textBox1);
            logInHolder.Controls.Add(textBox6);
            logInHolder.Controls.Add(textBox5);
            logInHolder.Controls.Add(textBox4);
            logInHolder.Controls.Add(tbUsername);
            logInHolder.Controls.Add(label9);
            logInHolder.Controls.Add(label8);
            logInHolder.Controls.Add(label1);
            logInHolder.Dock = DockStyle.Right;
            logInHolder.Location = new Point(461, 0);
            logInHolder.Name = "logInHolder";
            logInHolder.Size = new Size(669, 625);
            logInHolder.TabIndex = 0;
            // 
            // lbLogIn
            // 
            lbLogIn.ActiveLinkColor = Color.White;
            lbLogIn.AutoSize = true;
            lbLogIn.DisabledLinkColor = Color.Gray;
            lbLogIn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLogIn.LinkColor = Color.White;
            lbLogIn.Location = new Point(270, 583);
            lbLogIn.Name = "lbLogIn";
            lbLogIn.Size = new Size(152, 21);
            lbLogIn.TabIndex = 4;
            lbLogIn.TabStop = true;
            lbLogIn.Text = "Log In to Account";
            lbLogIn.VisitedLinkColor = Color.FromArgb(255, 192, 192);
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.FlatAppearance.BorderSize = 2;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(145, 522);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(400, 46);
            btnCreateAccount.TabIndex = 3;
            btnCreateAccount.Text = "CREATE ACCOUNT";
            btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 142);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.White;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(31, 159);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(289, 26);
            tbUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 29);
            label1.Name = "label1";
            label1.Size = new Size(520, 56);
            label1.TabIndex = 0;
            label1.Text = "CREATE AN ACCOUNT\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(67, 57);
            label4.Name = "label4";
            label4.Size = new Size(325, 56);
            label4.TabIndex = 0;
            label4.Text = "WELCOME TO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(31, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 26);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 197);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 2;
            label3.Text = "Middle Name";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(31, 273);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 26);
            textBox2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 256);
            label5.Name = "label5";
            label5.Size = new Size(77, 17);
            label5.TabIndex = 2;
            label5.Text = "Last Name";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(31, 333);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 26);
            textBox3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(28, 316);
            label6.Name = "label6";
            label6.Size = new Size(256, 17);
            label6.TabIndex = 2;
            label6.Text = "Suffix (If you have none, leave it blank)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(28, 378);
            label7.Name = "label7";
            label7.Size = new Size(88, 17);
            label7.TabIndex = 2;
            label7.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(26, 109);
            label8.Name = "label8";
            label8.Size = new Size(254, 23);
            label8.TabIndex = 0;
            label8.Text = "PERSONAL INFORMATION\r\n";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(31, 398);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(352, 109);
            label9.Name = "label9";
            label9.Size = new Size(255, 23);
            label9.TabIndex = 0;
            label9.Text = "ACCOUNT INFORMATION\r\n";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(352, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(289, 26);
            textBox4.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(349, 142);
            label10.Name = "label10";
            label10.Size = new Size(43, 17);
            label10.TabIndex = 2;
            label10.Text = "Email";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(352, 214);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(289, 26);
            textBox5.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(349, 197);
            label11.Name = "label11";
            label11.Size = new Size(69, 17);
            label11.TabIndex = 2;
            label11.Text = "Password";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(352, 273);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(289, 26);
            textBox6.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(349, 256);
            label12.Name = "label12";
            label12.Size = new Size(125, 17);
            label12.TabIndex = 2;
            label12.Text = "Confirm Password";
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1130, 625);
            Controls.Add(panelHolder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAccount";
            Text = "CreateAccount";
            panelHolder.ResumeLayout(false);
            panelHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            logInHolder.ResumeLayout(false);
            logInHolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHolder;
        private PictureBox pictureBox1;
        private Panel logInHolder;
        private LinkLabel lbLogIn;
        private Button btnCreateAccount;
        private Label label2;
        private TextBox tbUsername;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label9;
    }
}