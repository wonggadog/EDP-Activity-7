namespace Act5new
{
    partial class Form5
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
            button_updateprevious = new Button();
            text_updatepwd_previous = new TextBox();
            label3 = new Label();
            text_updateuser_previous = new TextBox();
            label2 = new Label();
            label_login = new Label();
            label1 = new Label();
            label4 = new Label();
            button1 = new Button();
            button_updateconfirm = new Button();
            text_updatepwd_final = new TextBox();
            label5 = new Label();
            text_updateuser_final = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button_updateprevious
            // 
            button_updateprevious.Font = new Font("MS UI Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_updateprevious.ForeColor = Color.FromArgb(116, 86, 174);
            button_updateprevious.Location = new Point(76, 289);
            button_updateprevious.Name = "button_updateprevious";
            button_updateprevious.Size = new Size(168, 28);
            button_updateprevious.TabIndex = 17;
            button_updateprevious.Text = "Update this Account";
            button_updateprevious.UseVisualStyleBackColor = true;
            button_updateprevious.Click += button_update_Click;
            // 
            // text_updatepwd_previous
            // 
            text_updatepwd_previous.BackColor = Color.FromArgb(230, 231, 233);
            text_updatepwd_previous.BorderStyle = BorderStyle.None;
            text_updatepwd_previous.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            text_updatepwd_previous.ForeColor = Color.Black;
            text_updatepwd_previous.Location = new Point(75, 227);
            text_updatepwd_previous.Multiline = true;
            text_updatepwd_previous.Name = "text_updatepwd_previous";
            text_updatepwd_previous.Size = new Size(168, 28);
            text_updatepwd_previous.TabIndex = 16;
            text_updatepwd_previous.TextChanged += text_updatepwd_previous_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(75, 209);
            label3.Name = "label3";
            label3.Size = new Size(54, 12);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // text_updateuser_previous
            // 
            text_updateuser_previous.BackColor = Color.FromArgb(230, 231, 233);
            text_updateuser_previous.BorderStyle = BorderStyle.None;
            text_updateuser_previous.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            text_updateuser_previous.ForeColor = Color.Black;
            text_updateuser_previous.Location = new Point(76, 163);
            text_updateuser_previous.Multiline = true;
            text_updateuser_previous.Name = "text_updateuser_previous";
            text_updateuser_previous.Size = new Size(168, 29);
            text_updateuser_previous.TabIndex = 14;
            text_updateuser_previous.TextChanged += text_updateuser_previous_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(76, 139);
            label2.Name = "label2";
            label2.Size = new Size(56, 12);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_login.ForeColor = Color.FromArgb(116, 86, 174);
            label_login.Location = new Point(75, 46);
            label_login.Name = "label_login";
            label_login.Size = new Size(345, 27);
            label_login.TabIndex = 12;
            label_login.Text = "Update an existing account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(76, 97);
            label1.Name = "label1";
            label1.Size = new Size(287, 16);
            label1.TabIndex = 24;
            label1.Text = "Enter previous account credentials below:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(116, 86, 174);
            label4.Location = new Point(467, 97);
            label4.Name = "label4";
            label4.Size = new Size(285, 16);
            label4.TabIndex = 32;
            label4.Text = "Enter updated account credentials below:";
            // 
            // button1
            // 
            button1.Font = new Font("MS UI Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(345, 379);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 31;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_updateconfirm
            // 
            button_updateconfirm.Font = new Font("MS UI Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_updateconfirm.ForeColor = Color.FromArgb(116, 86, 174);
            button_updateconfirm.Location = new Point(467, 289);
            button_updateconfirm.Name = "button_updateconfirm";
            button_updateconfirm.Size = new Size(168, 28);
            button_updateconfirm.TabIndex = 29;
            button_updateconfirm.Text = "Confirm Update";
            button_updateconfirm.UseVisualStyleBackColor = true;
            button_updateconfirm.Click += button_updateconfirm_Click;
            // 
            // text_updatepwd_final
            // 
            text_updatepwd_final.BackColor = Color.FromArgb(230, 231, 233);
            text_updatepwd_final.BorderStyle = BorderStyle.None;
            text_updatepwd_final.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            text_updatepwd_final.ForeColor = Color.Black;
            text_updatepwd_final.Location = new Point(466, 227);
            text_updatepwd_final.Multiline = true;
            text_updatepwd_final.Name = "text_updatepwd_final";
            text_updatepwd_final.Size = new Size(168, 28);
            text_updatepwd_final.TabIndex = 28;
            text_updatepwd_final.TextChanged += text_updatepwd_final_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(466, 209);
            label5.Name = "label5";
            label5.Size = new Size(54, 12);
            label5.TabIndex = 27;
            label5.Text = "Password";
            // 
            // text_updateuser_final
            // 
            text_updateuser_final.BackColor = Color.FromArgb(230, 231, 233);
            text_updateuser_final.BorderStyle = BorderStyle.None;
            text_updateuser_final.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            text_updateuser_final.ForeColor = Color.Black;
            text_updateuser_final.Location = new Point(467, 163);
            text_updateuser_final.Multiline = true;
            text_updateuser_final.Name = "text_updateuser_final";
            text_updateuser_final.Size = new Size(168, 29);
            text_updateuser_final.TabIndex = 26;
            text_updateuser_final.TextChanged += text_updateuser_final_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(467, 139);
            label6.Name = "label6";
            label6.Size = new Size(56, 12);
            label6.TabIndex = 25;
            label6.Text = "Username";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(button_updateconfirm);
            Controls.Add(text_updatepwd_final);
            Controls.Add(label5);
            Controls.Add(text_updateuser_final);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(button_updateprevious);
            Controls.Add(text_updatepwd_previous);
            Controls.Add(label3);
            Controls.Add(text_updateuser_previous);
            Controls.Add(label2);
            Controls.Add(label_login);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_updateprevious;
        private TextBox text_updatepwd_previous;
        private Label label3;
        private TextBox text_updateuser_previous;
        private Label label2;
        private Label label_login;
        private Label label1;
        private Label label4;
        private Button button1;
        private Button button_updateconfirm;
        private TextBox text_updatepwd_final;
        private Label label5;
        private TextBox text_updateuser_final;
        private Label label6;
    }
}