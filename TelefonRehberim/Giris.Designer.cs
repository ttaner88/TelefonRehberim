namespace TelefonRehberim
{
    partial class Giris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpSaat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTarih = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCikis = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnGiris = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(33)))));
            this.guna2Panel1.Controls.Add(this.dtpSaat);
            this.guna2Panel1.Controls.Add(this.dtpTarih);
            this.guna2Panel1.Controls.Add(this.btnCikis);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.btnGiris);
            this.guna2Panel1.Controls.Add(this.txtPassword);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(291, 430);
            this.guna2Panel1.TabIndex = 0;
            // 
            // dtpSaat
            // 
            this.dtpSaat.BorderRadius = 10;
            this.dtpSaat.BorderThickness = 2;
            this.dtpSaat.CheckedState.Parent = this.dtpSaat;
            this.dtpSaat.Enabled = false;
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaat.HoverState.Parent = this.dtpSaat;
            this.dtpSaat.Location = new System.Drawing.Point(12, 3);
            this.dtpSaat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSaat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.ShadowDecoration.Parent = this.dtpSaat;
            this.dtpSaat.Size = new System.Drawing.Size(98, 30);
            this.dtpSaat.TabIndex = 11;
            this.dtpSaat.Value = new System.DateTime(2022, 12, 30, 14, 58, 56, 897);
            // 
            // dtpTarih
            // 
            this.dtpTarih.BorderRadius = 10;
            this.dtpTarih.BorderThickness = 2;
            this.dtpTarih.CheckedState.Parent = this.dtpTarih;
            this.dtpTarih.Enabled = false;
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.HoverState.Parent = this.dtpTarih;
            this.dtpTarih.Location = new System.Drawing.Point(181, 3);
            this.dtpTarih.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTarih.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.ShadowDecoration.Parent = this.dtpTarih;
            this.dtpTarih.Size = new System.Drawing.Size(110, 30);
            this.dtpTarih.TabIndex = 10;
            this.dtpTarih.Value = new System.DateTime(2022, 12, 30, 14, 58, 56, 897);
            // 
            // btnCikis
            // 
            this.btnCikis.Animated = true;
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BorderColor = System.Drawing.Color.LightCoral;
            this.btnCikis.BorderRadius = 10;
            this.btnCikis.BorderThickness = 2;
            this.btnCikis.CheckedState.Parent = this.btnCikis;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.CustomImages.Parent = this.btnCikis;
            this.btnCikis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.HoverState.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.HoverState.Parent = this.btnCikis;
            this.btnCikis.Location = new System.Drawing.Point(176, 281);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ShadowDecoration.Parent = this.btnCikis;
            this.btnCikis.Size = new System.Drawing.Size(86, 30);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseTransparentBackground = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(70, 91);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(153, 119);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnGiris
            // 
            this.btnGiris.Animated = true;
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.BorderColor = System.Drawing.Color.LightCoral;
            this.btnGiris.BorderRadius = 10;
            this.btnGiris.CheckedState.Parent = this.btnGiris;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.CustomImages.Parent = this.btnGiris;
            this.btnGiris.FillColor = System.Drawing.Color.LightCoral;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.HoverState.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.HoverState.Parent = this.btnGiris;
            this.btnGiris.Location = new System.Drawing.Point(30, 281);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.ShadowDecoration.Parent = this.btnGiris;
            this.btnGiris.Size = new System.Drawing.Size(86, 30);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseTransparentBackground = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.LightCoral;
            this.txtPassword.BorderRadius = 8;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "123456789";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(33)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPassword.IconLeft")));
            this.txtPassword.Location = new System.Drawing.Point(30, 239);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtPassword.PlaceholderText = "Şifre Giriniz";
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionStart = 9;
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(232, 36);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // Giris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 430);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnGiris;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnCikis;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSaat;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTarih;
    }
}

