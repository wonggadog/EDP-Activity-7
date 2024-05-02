namespace Act5new
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button_deleteconfirm = new Button();
            delete_password = new TextBox();
            label2 = new Label();
            delete_username = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(69, 71);
            label3.Name = "label3";
            label3.Size = new Size(226, 27);
            label3.TabIndex = 13;
            label3.Text = "Delete an Account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(423, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button_deleteconfirm
            // 
            button_deleteconfirm.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_deleteconfirm.ForeColor = Color.FromArgb(116, 86, 174);
            button_deleteconfirm.Location = new Point(176, 356);
            button_deleteconfirm.Name = "button_deleteconfirm";
            button_deleteconfirm.Size = new Size(75, 23);
            button_deleteconfirm.TabIndex = 11;
            button_deleteconfirm.Text = "Delete";
            button_deleteconfirm.UseVisualStyleBackColor = true;
            button_deleteconfirm.Click += button_deleteconfirm_Click;
            // 
            // delete_password
            // 
            delete_password.BackColor = Color.FromArgb(230, 231, 233);
            delete_password.BorderStyle = BorderStyle.None;
            delete_password.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            delete_password.Location = new Point(69, 272);
            delete_password.Multiline = true;
            delete_password.Name = "delete_password";
            delete_password.Size = new Size(182, 31);
            delete_password.TabIndex = 10;
            delete_password.TextChanged += delete_password_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(69, 247);
            label2.Name = "label2";
            label2.Size = new Size(54, 12);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // delete_username
            // 
            delete_username.BackColor = Color.FromArgb(230, 231, 233);
            delete_username.BorderStyle = BorderStyle.None;
            delete_username.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            delete_username.Location = new Point(69, 180);
            delete_username.Multiline = true;
            delete_username.Name = "delete_username";
            delete_username.Size = new Size(182, 31);
            delete_username.TabIndex = 8;
            delete_username.TextChanged += delete_username_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(69, 151);
            label1.Name = "label1";
            label1.Size = new Size(56, 12);
            label1.TabIndex = 7;
            label1.Text = "Username";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button_deleteconfirm);
            Controls.Add(delete_password);
            Controls.Add(label2);
            Controls.Add(delete_username);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
        private Button button_deleteconfirm;
        private TextBox delete_password;
        private Label label2;
        private TextBox delete_username;
        private Label label1;
    }
}