namespace Act5new
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            recovery_username = new TextBox();
            button_recover = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(86, 84);
            label1.Name = "label1";
            label1.Size = new Size(253, 27);
            label1.TabIndex = 0;
            label1.Text = "Password Recovery";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(86, 188);
            label2.Name = "label2";
            label2.Size = new Size(154, 16);
            label2.TabIndex = 1;
            label2.Text = "Enter your Username:";
            label2.Click += label2_Click;
            // 
            // recovery_username
            // 
            recovery_username.BorderStyle = BorderStyle.None;
            recovery_username.Location = new Point(86, 216);
            recovery_username.Multiline = true;
            recovery_username.Name = "recovery_username";
            recovery_username.Size = new Size(253, 23);
            recovery_username.TabIndex = 2;
            recovery_username.TextChanged += recovery_username_TextChanged;
            // 
            // button_recover
            // 
            button_recover.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_recover.ForeColor = Color.FromArgb(116, 86, 174);
            button_recover.Location = new Point(264, 258);
            button_recover.Name = "button_recover";
            button_recover.Size = new Size(75, 23);
            button_recover.TabIndex = 3;
            button_recover.Text = "Recover";
            button_recover.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(456, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button_recover);
            Controls.Add(recovery_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox recovery_username;
        private Button button_recover;
        private PictureBox pictureBox1;
    }
}