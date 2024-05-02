namespace Act5new
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            register_username = new TextBox();
            register_password = new TextBox();
            label2 = new Label();
            button_registercomplete = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(86, 121);
            label1.Name = "label1";
            label1.Size = new Size(56, 12);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // register_username
            // 
            register_username.BackColor = Color.FromArgb(230, 231, 233);
            register_username.BorderStyle = BorderStyle.None;
            register_username.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            register_username.Location = new Point(86, 136);
            register_username.Multiline = true;
            register_username.Name = "register_username";
            register_username.Size = new Size(182, 31);
            register_username.TabIndex = 1;
            register_username.TextChanged += register_username_TextChanged;
            // 
            // register_password
            // 
            register_password.BackColor = Color.FromArgb(230, 231, 233);
            register_password.BorderStyle = BorderStyle.None;
            register_password.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            register_password.Location = new Point(86, 232);
            register_password.Multiline = true;
            register_password.Name = "register_password";
            register_password.Size = new Size(182, 31);
            register_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(86, 217);
            label2.Name = "label2";
            label2.Size = new Size(54, 12);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // button_registercomplete
            // 
            button_registercomplete.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_registercomplete.ForeColor = Color.FromArgb(116, 86, 174);
            button_registercomplete.Location = new Point(193, 326);
            button_registercomplete.Name = "button_registercomplete";
            button_registercomplete.Size = new Size(75, 23);
            button_registercomplete.TabIndex = 4;
            button_registercomplete.Text = "Register";
            button_registercomplete.UseVisualStyleBackColor = true;
            button_registercomplete.Click += button_registercomplete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(426, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(86, 41);
            label3.Name = "label3";
            label3.Size = new Size(284, 27);
            label3.TabIndex = 6;
            label3.Text = "Register a new Account";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button_registercomplete);
            Controls.Add(register_password);
            Controls.Add(label2);
            Controls.Add(register_username);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox register_username;
        private TextBox register_password;
        private Label label2;
        private Button button_registercomplete;
        private PictureBox pictureBox1;
        private Label label3;
    }
}