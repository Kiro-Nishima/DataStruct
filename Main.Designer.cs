namespace DataStruct
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            formControlHolder = new Panel();
            minimize = new PictureBox();
            exit = new PictureBox();
            panelFormHolder = new Panel();
            btnExit = new Button();
            btnLogIn = new Button();
            pictureBox1 = new PictureBox();
            formControlHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            panelFormHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // formControlHolder
            // 
            formControlHolder.BackColor = Color.Maroon;
            formControlHolder.Controls.Add(minimize);
            formControlHolder.Controls.Add(exit);
            formControlHolder.Dock = DockStyle.Top;
            formControlHolder.Location = new Point(0, 0);
            formControlHolder.Name = "formControlHolder";
            formControlHolder.Size = new Size(1130, 30);
            formControlHolder.TabIndex = 1;
            formControlHolder.MouseDown += dragMouseDown;
            formControlHolder.MouseMove += dragMouseMove;
            formControlHolder.MouseUp += dragMouseUp;
            // 
            // minimize
            // 
            minimize.BackColor = Color.Transparent;
            minimize.BackgroundImage = (Image)resources.GetObject("minimize.BackgroundImage");
            minimize.BackgroundImageLayout = ImageLayout.Zoom;
            minimize.Location = new Point(1066, 0);
            minimize.Name = "minimize";
            minimize.Size = new Size(30, 30);
            minimize.TabIndex = 0;
            minimize.TabStop = false;
            minimize.Click += minimize_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.BackgroundImage = (Image)resources.GetObject("exit.BackgroundImage");
            exit.BackgroundImageLayout = ImageLayout.Zoom;
            exit.Location = new Point(1098, 0);
            exit.Name = "exit";
            exit.Size = new Size(30, 30);
            exit.TabIndex = 0;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // panelFormHolder
            // 
            panelFormHolder.Controls.Add(btnExit);
            panelFormHolder.Controls.Add(btnLogIn);
            panelFormHolder.Controls.Add(pictureBox1);
            panelFormHolder.Dock = DockStyle.Fill;
            panelFormHolder.Location = new Point(0, 30);
            panelFormHolder.Name = "panelFormHolder";
            panelFormHolder.Size = new Size(1130, 633);
            panelFormHolder.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(390, 508);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(348, 41);
            btnExit.TabIndex = 1;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.DarkRed;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(390, 443);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(348, 41);
            btnLogIn.TabIndex = 1;
            btnLogIn.Text = "LOG IN";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1130, 633);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1130, 663);
            Controls.Add(panelFormHolder);
            Controls.Add(formControlHolder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            formControlHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            panelFormHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formControlHolder;
        private PictureBox minimize;
        private PictureBox exit;
        private Panel panelFormHolder;
        private Button btnLogIn;
        private PictureBox pictureBox1;
        private Button btnExit;
    }
}