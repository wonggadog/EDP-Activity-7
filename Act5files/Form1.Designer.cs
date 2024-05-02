namespace Act5new
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label_login = new Label();
            label2 = new Label();
            text_username = new TextBox();
            txtpassword = new TextBox();
            label3 = new Label();
            button_login = new Button();
            button_clear = new Button();
            button_exit = new Button();
            button_register = new Button();
            button_forgotpass = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_login.ForeColor = Color.FromArgb(116, 86, 174);
            label_login.Location = new Point(66, 49);
            label_login.Name = "label_login";
            label_login.Size = new Size(87, 27);
            label_login.TabIndex = 0;
            label_login.Text = "Log in";
            label_login.Click += label_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(67, 142);
            label2.Name = "label2";
            label2.Size = new Size(56, 12);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // text_username
            // 
            text_username.BackColor = Color.FromArgb(230, 231, 233);
            text_username.BorderStyle = BorderStyle.None;
            text_username.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_username.ForeColor = Color.Black;
            text_username.Location = new Point(67, 166);
            text_username.Multiline = true;
            text_username.Name = "text_username";
            text_username.Size = new Size(168, 29);
            text_username.TabIndex = 2;
            text_username.TextChanged += text_username_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(230, 231, 233);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.Black;
            txtpassword.Location = new Point(66, 230);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(168, 28);
            txtpassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(66, 212);
            label3.Name = "label3";
            label3.Size = new Size(54, 12);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // button_login
            // 
            button_login.Font = new Font("MS UI Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_login.ForeColor = Color.FromArgb(116, 86, 174);
            button_login.Location = new Point(152, 310);
            button_login.Name = "button_login";
            button_login.Size = new Size(83, 29);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_clear
            // 
            button_clear.Font = new Font("MS UI Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_clear.ForeColor = Color.FromArgb(116, 86, 174);
            button_clear.Location = new Point(67, 387);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(75, 29);
            button_clear.TabIndex = 6;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_exit
            // 
            button_exit.Font = new Font("MS UI Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.ForeColor = Color.FromArgb(116, 86, 174);
            button_exit.Location = new Point(160, 387);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(75, 29);
            button_exit.TabIndex = 7;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_register
            // 
            button_register.Font = new Font("MS UI Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_register.ForeColor = Color.FromArgb(116, 86, 174);
            button_register.Location = new Point(67, 310);
            button_register.Name = "button_register";
            button_register.Size = new Size(87, 29);
            button_register.TabIndex = 8;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // button_forgotpass
            // 
            button_forgotpass.BackColor = Color.Transparent;
            button_forgotpass.BackgroundImageLayout = ImageLayout.None;
            button_forgotpass.Font = new Font("MS UI Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_forgotpass.ForeColor = Color.FromArgb(116, 86, 174);
            button_forgotpass.Location = new Point(66, 275);
            button_forgotpass.Name = "button_forgotpass";
            button_forgotpass.Size = new Size(169, 29);
            button_forgotpass.TabIndex = 9;
            button_forgotpass.Text = "Forgot your password?";
            button_forgotpass.UseVisualStyleBackColor = false;
            button_forgotpass.Click += button_forgotpass_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(443, 41);
            label1.Name = "label1";
            label1.Size = new Size(261, 35);
            label1.TabIndex = 10;
            label1.Text = "Al's Rare Vinyls";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(434, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 492);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button_forgotpass);
            Controls.Add(button_register);
            Controls.Add(button_exit);
            Controls.Add(button_clear);
            Controls.Add(button_login);
            Controls.Add(txtpassword);
            Controls.Add(label3);
            Controls.Add(text_username);
            Controls.Add(label2);
            Controls.Add(label_login);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_login;
        private Label label2;
        private TextBox text_username;
        private TextBox txtpassword;
        private Label label3;
        private Button button_login;
        private Button button_clear;
        private Button button_exit;
        private Button button_register;
        private Button button_forgotpass;
        private Label label1;
        private PictureBox pictureBox1;
    }
}