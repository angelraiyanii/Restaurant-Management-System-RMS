
namespace RMS
{
    partial class Registor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.reg_signin = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_showpass = new System.Windows.Forms.CheckBox();
            this.reg_btn = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordR = new Guna.UI2.WinForms.Guna2TextBox();
            this.Rusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.Rpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.reg_signin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(294, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 453);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 51);
            this.label5.TabIndex = 6;
            this.label5.Text = "Restaurent Management System";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::RMS.Properties.Resources.Mainform_logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(71, 45);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(135, 117);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // reg_signin
            // 
            this.reg_signin.BorderRadius = 12;
            this.reg_signin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reg_signin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reg_signin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reg_signin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reg_signin.FillColor = System.Drawing.Color.Teal;
            this.reg_signin.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.reg_signin.ForeColor = System.Drawing.Color.White;
            this.reg_signin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.reg_signin.Location = new System.Drawing.Point(46, 372);
            this.reg_signin.Name = "reg_signin";
            this.reg_signin.Size = new System.Drawing.Size(183, 45);
            this.reg_signin.TabIndex = 4;
            this.reg_signin.Text = "Sign IN";
            this.reg_signin.Click += new System.EventHandler(this.reg_signin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "You Have No Account..!";
            // 
            // reg_showpass
            // 
            this.reg_showpass.AutoSize = true;
            this.reg_showpass.Location = new System.Drawing.Point(52, 319);
            this.reg_showpass.Name = "reg_showpass";
            this.reg_showpass.Size = new System.Drawing.Size(102, 17);
            this.reg_showpass.TabIndex = 31;
            this.reg_showpass.Text = "Show Password";
            this.reg_showpass.UseVisualStyleBackColor = true;
            this.reg_showpass.CheckedChanged += new System.EventHandler(this.reg_showpass_CheckedChanged);
            // 
            // reg_btn
            // 
            this.reg_btn.BorderRadius = 12;
            this.reg_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reg_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reg_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reg_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reg_btn.FillColor = System.Drawing.Color.Teal;
            this.reg_btn.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.reg_btn.ForeColor = System.Drawing.Color.White;
            this.reg_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.reg_btn.Location = new System.Drawing.Point(84, 370);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(141, 45);
            this.reg_btn.TabIndex = 30;
            this.reg_btn.Text = "Save";
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click_1);
            // 
            // PasswordR
            // 
            this.PasswordR.BorderRadius = 10;
            this.PasswordR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordR.DefaultText = "";
            this.PasswordR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordR.Location = new System.Drawing.Point(44, 199);
            this.PasswordR.Name = "PasswordR";
            this.PasswordR.PasswordChar = '\0';
            this.PasswordR.PlaceholderText = "";
            this.PasswordR.SelectedText = "";
            this.PasswordR.Size = new System.Drawing.Size(200, 36);
            this.PasswordR.TabIndex = 27;
            // 
            // Rusername
            // 
            this.Rusername.BorderRadius = 10;
            this.Rusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rusername.DefaultText = "";
            this.Rusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Rusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Rusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rusername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Rusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rusername.Location = new System.Drawing.Point(44, 126);
            this.Rusername.Name = "Rusername";
            this.Rusername.PasswordChar = '\0';
            this.Rusername.PlaceholderText = "";
            this.Rusername.SelectedText = "";
            this.Rusername.Size = new System.Drawing.Size(200, 36);
            this.Rusername.TabIndex = 28;
            // 
            // Rpassword
            // 
            this.Rpassword.BorderRadius = 10;
            this.Rpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rpassword.DefaultText = "";
            this.Rpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Rpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Rpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rpassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Rpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rpassword.Location = new System.Drawing.Point(44, 277);
            this.Rpassword.Name = "Rpassword";
            this.Rpassword.PasswordChar = '●';
            this.Rpassword.PlaceholderText = "";
            this.Rpassword.SelectedText = "";
            this.Rpassword.Size = new System.Drawing.Size(200, 36);
            this.Rpassword.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sign UP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Username";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(266, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 24;
            // 
            // Registor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 453);
            this.Controls.Add(this.reg_showpass);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.PasswordR);
            this.Controls.Add(this.Rusername);
            this.Controls.Add(this.Rpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button reg_signin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox reg_showpass;
        private Guna.UI2.WinForms.Guna2Button reg_btn;
        private Guna.UI2.WinForms.Guna2TextBox PasswordR;
        private Guna.UI2.WinForms.Guna2TextBox Rusername;
        private Guna.UI2.WinForms.Guna2TextBox Rpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}