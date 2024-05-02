namespace Act5new
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button_dashboard_logout = new Button();
            button_dashboard_anotheracc = new Button();
            button_dashboard_reportgen = new Button();
            button_dashboard_abt = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            button_dashboard_register = new Button();
            button_dashboard_updateacc = new Button();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            button_dashboard_delete = new Button();
            pictureBox7 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(188, 36);
            label1.Name = "label1";
            label1.Size = new Size(319, 33);
            label1.TabIndex = 0;
            label1.Text = "Al's Rare Vinyl Albums";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(523, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(181, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(260, 131);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 3;
            label2.Text = "Active Users:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(292, 169);
            label3.Name = "label3";
            label3.Size = new Size(19, 21);
            label3.TabIndex = 4;
            label3.Text = "1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(116, 86, 174);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-7, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 95);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(186, 163, 116);
            panel2.Location = new Point(19, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(86, 184);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(116, 86, 174);
            panel3.Controls.Add(button_dashboard_logout);
            panel3.Controls.Add(button_dashboard_anotheracc);
            panel3.Controls.Add(button_dashboard_reportgen);
            panel3.Controls.Add(button_dashboard_abt);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(-4, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(179, 376);
            panel3.TabIndex = 7;
            // 
            // button_dashboard_logout
            // 
            button_dashboard_logout.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_dashboard_logout.ForeColor = Color.FromArgb(116, 86, 174);
            button_dashboard_logout.Location = new Point(16, 262);
            button_dashboard_logout.Name = "button_dashboard_logout";
            button_dashboard_logout.Size = new Size(149, 41);
            button_dashboard_logout.TabIndex = 13;
            button_dashboard_logout.Text = "Log Out";
            button_dashboard_logout.UseVisualStyleBackColor = true;
            button_dashboard_logout.Click += button_dashboard_logout_Click;
            // 
            // button_dashboard_anotheracc
            // 
            button_dashboard_anotheracc.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_dashboard_anotheracc.ForeColor = Color.FromArgb(116, 86, 174);
            button_dashboard_anotheracc.Location = new Point(16, 54);
            button_dashboard_anotheracc.Name = "button_dashboard_anotheracc";
            button_dashboard_anotheracc.Size = new Size(149, 42);
            button_dashboard_anotheracc.TabIndex = 14;
            button_dashboard_anotheracc.Text = "Sign in another account";
            button_dashboard_anotheracc.UseVisualStyleBackColor = true;
            button_dashboard_anotheracc.Click += button4_Click;
            // 
            // button_dashboard_reportgen
            // 
            button_dashboard_reportgen.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_dashboard_reportgen.ForeColor = Color.FromArgb(116, 86, 174);
            button_dashboard_reportgen.Location = new Point(16, 122);
            button_dashboard_reportgen.Name = "button_dashboard_reportgen";
            button_dashboard_reportgen.Size = new Size(149, 42);
            button_dashboard_reportgen.TabIndex = 13;
            button_dashboard_reportgen.Text = "Report Generator";
            button_dashboard_reportgen.UseVisualStyleBackColor = true;
            button_dashboard_reportgen.Click += button3_Click;
            // 
            // button_dashboard_abt
            // 
            button_dashboard_abt.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_dashboard_abt.ForeColor = Color.FromArgb(116, 86, 174);
            button_dashboard_abt.Location = new Point(16, 191);
            button_dashboard_abt.Name = "button_dashboard_abt";
            button_dashboard_abt.Size = new Size(149, 41);
            button_dashboard_abt.TabIndex = 12;
            button_dashboard_abt.Text = "About";
            button_dashboard_abt.UseVisualStyleBackColor = true;
            button_dashboard_abt.Click += button_dashboard_abt_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(494, 26);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(65, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(561, 131);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(73, 68);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(116, 86, 174);
            label4.Location = new Point(640, 131);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 9;
            label4.Text = "Add an Account:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(676, 149);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 10;
            // 
            // button_dashboard_register
            // 
            button_dashboard_register.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_dashboard_register.ForeColor = Color.FromArgb(116, 86, 174);
            button_dashboard_register.Location = new Point(657, 162);
            button_dashboard_register.Name = "button_dashboard_register";
            button_dashboard_register.Size = new Size(81, 37);
            button_dashboard_register.TabIndex = 11;
            button_dashboard_register.Text = "Register";
            button_dashboard_register.UseVisualStyleBackColor = true;
            button_dashboard_register.Click += button_dashboard_register_Click;
            // 
            // button_dashboard_updateacc
            // 
            button_dashboard_updateacc.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_dashboard_updateacc.ForeColor = Color.FromArgb(116, 86, 174);
            button_dashboard_updateacc.Location = new Point(277, 325);
            button_dashboard_updateacc.Name = "button_dashboard_updateacc";
            button_dashboard_updateacc.Size = new Size(81, 37);
            button_dashboard_updateacc.TabIndex = 15;
            button_dashboard_updateacc.Text = "Update";
            button_dashboard_updateacc.UseVisualStyleBackColor = true;
            button_dashboard_updateacc.Click += button_dashboard_updateacc_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(181, 294);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(73, 68);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(260, 294);
            label6.Name = "label6";
            label6.Size = new Size(144, 21);
            label6.TabIndex = 13;
            label6.Text = "Update an Account:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(296, 312);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 14;
            // 
            // button_dashboard_delete
            // 
            button_dashboard_delete.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_dashboard_delete.ForeColor = Color.FromArgb(116, 86, 174);
            button_dashboard_delete.Location = new Point(657, 325);
            button_dashboard_delete.Name = "button_dashboard_delete";
            button_dashboard_delete.Size = new Size(81, 37);
            button_dashboard_delete.TabIndex = 19;
            button_dashboard_delete.Text = "Delete";
            button_dashboard_delete.UseVisualStyleBackColor = true;
            button_dashboard_delete.Click += button_dashboard_delete_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(561, 294);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(73, 68);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(116, 86, 174);
            label8.Location = new Point(640, 294);
            label8.Name = "label8";
            label8.Size = new Size(138, 21);
            label8.TabIndex = 17;
            label8.Text = "Delete an Account:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(676, 312);
            label9.Name = "label9";
            label9.Size = new Size(0, 21);
            label9.TabIndex = 18;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(260, 169);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 231, 233);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(button_dashboard_delete);
            Controls.Add(pictureBox7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(button_dashboard_updateacc);
            Controls.Add(pictureBox6);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(button_dashboard_register);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label4;
        private Label label5;
        private Button button_dashboard_register;
        private Button button_dashboard_reportgen;
        private Button button_dashboard_abt;
        private Button button_dashboard_logout;
        private Button button_dashboard_anotheracc;
        private Button button_dashboard_updateacc;
        private PictureBox pictureBox6;
        private Label label6;
        private Label label7;
        private Button button_dashboard_delete;
        private PictureBox pictureBox7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox3;
    }
}