namespace QuanLyBanHang
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TenDangNhapBox = new System.Windows.Forms.TextBox();
            this.MatKhauBox = new System.Windows.Forms.TextBox();
            this.DangNhapButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ShowError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Coverer = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.Coverer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(76, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // TenDangNhapBox
            // 
            this.TenDangNhapBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDangNhapBox.Location = new System.Drawing.Point(157, 68);
            this.TenDangNhapBox.MaxLength = 20;
            this.TenDangNhapBox.Name = "TenDangNhapBox";
            this.TenDangNhapBox.Size = new System.Drawing.Size(192, 22);
            this.TenDangNhapBox.TabIndex = 2;
            // 
            // MatKhauBox
            // 
            this.MatKhauBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhauBox.Location = new System.Drawing.Point(157, 110);
            this.MatKhauBox.MaxLength = 20;
            this.MatKhauBox.Name = "MatKhauBox";
            this.MatKhauBox.PasswordChar = '*';
            this.MatKhauBox.Size = new System.Drawing.Size(192, 22);
            this.MatKhauBox.TabIndex = 3;
            // 
            // DangNhapButton
            // 
            this.DangNhapButton.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.DangNhapButton.FlatAppearance.BorderSize = 3;
            this.DangNhapButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.DangNhapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DangNhapButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhapButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DangNhapButton.Location = new System.Drawing.Point(168, 148);
            this.DangNhapButton.Name = "DangNhapButton";
            this.DangNhapButton.Size = new System.Drawing.Size(129, 35);
            this.DangNhapButton.TabIndex = 4;
            this.DangNhapButton.Text = "Đăng Nhập";
            this.DangNhapButton.UseVisualStyleBackColor = true;
            this.DangNhapButton.Click += new System.EventHandler(this.DangNhapButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.MediumTurquoise;
            this.linkLabel1.Location = new System.Drawing.Point(182, 197);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên Mật Khẩu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ShowError
            // 
            this.ShowError.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowError.ForeColor = System.Drawing.Color.Red;
            this.ShowError.Location = new System.Drawing.Point(39, 30);
            this.ShowError.Name = "ShowError";
            this.ShowError.Size = new System.Drawing.Size(365, 25);
            this.ShowError.TabIndex = 6;
            this.ShowError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.Coverer);
            this.groupBox1.Location = new System.Drawing.Point(-19, -14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 305);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Coverer
            // 
            this.Coverer.BackColor = System.Drawing.Color.Black;
            this.Coverer.Controls.Add(this.label1);
            this.Coverer.Controls.Add(this.TenDangNhapBox);
            this.Coverer.Controls.Add(this.ShowError);
            this.Coverer.Controls.Add(this.label2);
            this.Coverer.Controls.Add(this.MatKhauBox);
            this.Coverer.Controls.Add(this.linkLabel1);
            this.Coverer.Controls.Add(this.DangNhapButton);
            this.Coverer.ForeColor = System.Drawing.Color.Black;
            this.Coverer.Location = new System.Drawing.Point(6, 0);
            this.Coverer.Name = "Coverer";
            this.Coverer.Size = new System.Drawing.Size(442, 299);
            this.Coverer.TabIndex = 7;
            this.Coverer.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 279);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.Coverer.ResumeLayout(false);
            this.Coverer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TenDangNhapBox;
        private System.Windows.Forms.TextBox MatKhauBox;
        private System.Windows.Forms.Button DangNhapButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label ShowError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Coverer;
    }
}