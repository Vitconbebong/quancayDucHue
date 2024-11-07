namespace QuanLyBanHang
{
    partial class ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewTab = new System.Windows.Forms.TabControl();
            this.KhachHangTab = new System.Windows.Forms.TabPage();
            this.KhachHangView = new System.Windows.Forms.DataGridView();
            this.HangHoaTab = new System.Windows.Forms.TabPage();
            this.HangHoaView = new System.Windows.Forms.DataGridView();
            this.HoaDonTab = new System.Windows.Forms.TabPage();
            this.HoaDonBanView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Box3 = new System.Windows.Forms.TextBox();
            this.Box4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.TacVuGroup = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.TimKiemBox = new System.Windows.Forms.TextBox();
            this.TimKiemButton = new System.Windows.Forms.Button();
            this.TimKiemGroup = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ViewTab.SuspendLayout();
            this.KhachHangTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangView)).BeginInit();
            this.HangHoaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaView)).BeginInit();
            this.HoaDonTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBanView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.TacVuGroup.SuspendLayout();
            this.TimKiemGroup.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1002, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUÁN CAY ĐỨC HUỆ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ViewTab
            // 
            this.ViewTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.ViewTab.Controls.Add(this.KhachHangTab);
            this.ViewTab.Controls.Add(this.HangHoaTab);
            this.ViewTab.Controls.Add(this.HoaDonTab);
            this.ViewTab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTab.Location = new System.Drawing.Point(334, 154);
            this.ViewTab.Name = "ViewTab";
            this.ViewTab.SelectedIndex = 0;
            this.ViewTab.Size = new System.Drawing.Size(656, 392);
            this.ViewTab.TabIndex = 2;
            this.ViewTab.SelectedIndexChanged += new System.EventHandler(this.ViewTab_SelectedIndexChanged);
            this.ViewTab.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.ViewTab_Selecting);
            // 
            // KhachHangTab
            // 
            this.KhachHangTab.Controls.Add(this.KhachHangView);
            this.KhachHangTab.Location = new System.Drawing.Point(4, 33);
            this.KhachHangTab.Name = "KhachHangTab";
            this.KhachHangTab.Padding = new System.Windows.Forms.Padding(3);
            this.KhachHangTab.Size = new System.Drawing.Size(648, 355);
            this.KhachHangTab.TabIndex = 0;
            this.KhachHangTab.Text = "Khách Hàng";
            this.KhachHangTab.UseVisualStyleBackColor = true;
            // 
            // KhachHangView
            // 
            this.KhachHangView.AllowUserToAddRows = false;
            this.KhachHangView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KhachHangView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KhachHangView.Location = new System.Drawing.Point(0, 0);
            this.KhachHangView.Name = "KhachHangView";
            this.KhachHangView.ReadOnly = true;
            this.KhachHangView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KhachHangView.Size = new System.Drawing.Size(648, 367);
            this.KhachHangView.TabIndex = 0;
            this.KhachHangView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KhachHangView_CellClick);
            // 
            // HangHoaTab
            // 
            this.HangHoaTab.Controls.Add(this.HangHoaView);
            this.HangHoaTab.Location = new System.Drawing.Point(4, 33);
            this.HangHoaTab.Name = "HangHoaTab";
            this.HangHoaTab.Padding = new System.Windows.Forms.Padding(3);
            this.HangHoaTab.Size = new System.Drawing.Size(648, 355);
            this.HangHoaTab.TabIndex = 1;
            this.HangHoaTab.Text = "Hàng Hóa";
            this.HangHoaTab.UseVisualStyleBackColor = true;
            // 
            // HangHoaView
            // 
            this.HangHoaView.AllowUserToAddRows = false;
            this.HangHoaView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HangHoaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HangHoaView.Location = new System.Drawing.Point(0, 0);
            this.HangHoaView.Name = "HangHoaView";
            this.HangHoaView.ReadOnly = true;
            this.HangHoaView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HangHoaView.Size = new System.Drawing.Size(648, 363);
            this.HangHoaView.TabIndex = 1;
            this.HangHoaView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HangHoaView_CellClick);
            // 
            // HoaDonTab
            // 
            this.HoaDonTab.Controls.Add(this.HoaDonBanView);
            this.HoaDonTab.Location = new System.Drawing.Point(4, 33);
            this.HoaDonTab.Name = "HoaDonTab";
            this.HoaDonTab.Padding = new System.Windows.Forms.Padding(3);
            this.HoaDonTab.Size = new System.Drawing.Size(648, 355);
            this.HoaDonTab.TabIndex = 2;
            this.HoaDonTab.Text = "Hóa Đơn Bán";
            this.HoaDonTab.UseVisualStyleBackColor = true;
            // 
            // HoaDonBanView
            // 
            this.HoaDonBanView.AllowUserToAddRows = false;
            this.HoaDonBanView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HoaDonBanView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HoaDonBanView.Location = new System.Drawing.Point(0, 0);
            this.HoaDonBanView.Name = "HoaDonBanView";
            this.HoaDonBanView.ReadOnly = true;
            this.HoaDonBanView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HoaDonBanView.Size = new System.Drawing.Size(648, 363);
            this.HoaDonBanView.TabIndex = 1;
            this.HoaDonBanView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HoaDonBanView_CellClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 3;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 4;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(488, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 5;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(729, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 6;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Box1
            // 
            this.Box1.Enabled = false;
            this.Box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box1.Location = new System.Drawing.Point(78, 21);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(155, 21);
            this.Box1.TabIndex = 7;
            this.Box1.TextChanged += new System.EventHandler(this.Box1_TextChanged);
            // 
            // Box2
            // 
            this.Box2.Enabled = false;
            this.Box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box2.Location = new System.Drawing.Point(317, 21);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(165, 21);
            this.Box2.TabIndex = 8;
            this.Box2.TextChanged += new System.EventHandler(this.Box2_TextChanged);
            // 
            // Box3
            // 
            this.Box3.Enabled = false;
            this.Box3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box3.Location = new System.Drawing.Point(568, 21);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(155, 21);
            this.Box3.TabIndex = 9;
            this.Box3.TextChanged += new System.EventHandler(this.Box3_TextChanged);
            // 
            // Box4
            // 
            this.Box4.Enabled = false;
            this.Box4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box4.Location = new System.Drawing.Point(803, 21);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(155, 21);
            this.Box4.TabIndex = 10;
            this.Box4.TextChanged += new System.EventHandler(this.Box4_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.Box4);
            this.groupBox1.Controls.Add(this.Box3);
            this.groupBox1.Controls.Add(this.Box2);
            this.groupBox1.Controls.Add(this.Box1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 66);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(18, 25);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(219, 38);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(18, 91);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(219, 38);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Sửa";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(18, 159);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(219, 38);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // TacVuGroup
            // 
            this.TacVuGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TacVuGroup.Controls.Add(this.SaveButton);
            this.TacVuGroup.Controls.Add(this.cancelButton);
            this.TacVuGroup.Controls.Add(this.DeleteButton);
            this.TacVuGroup.Controls.Add(this.UpdateButton);
            this.TacVuGroup.Controls.Add(this.AddButton);
            this.TacVuGroup.Location = new System.Drawing.Point(36, 129);
            this.TacVuGroup.Name = "TacVuGroup";
            this.TacVuGroup.Size = new System.Drawing.Size(255, 234);
            this.TacVuGroup.TabIndex = 15;
            this.TacVuGroup.TabStop = false;
            this.TacVuGroup.Text = "Tác Vụ";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(18, 91);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(219, 38);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(18, 159);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(219, 38);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Hủy";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // TimKiemBox
            // 
            this.TimKiemBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimKiemBox.Location = new System.Drawing.Point(20, 27);
            this.TimKiemBox.Name = "TimKiemBox";
            this.TimKiemBox.Size = new System.Drawing.Size(193, 20);
            this.TimKiemBox.TabIndex = 17;
            this.TimKiemBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimKiemBox.Enter += new System.EventHandler(this.TimKiemBox_Enter);
            this.TimKiemBox.Leave += new System.EventHandler(this.TimKiemBox_Leave);
            // 
            // TimKiemButton
            // 
            this.TimKiemButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiemButton.Location = new System.Drawing.Point(74, 53);
            this.TimKiemButton.Name = "TimKiemButton";
            this.TimKiemButton.Size = new System.Drawing.Size(87, 29);
            this.TimKiemButton.TabIndex = 18;
            this.TimKiemButton.Text = "Tìm Kiếm";
            this.TimKiemButton.UseVisualStyleBackColor = true;
            this.TimKiemButton.Click += new System.EventHandler(this.TimKiemButton_Click);
            // 
            // TimKiemGroup
            // 
            this.TimKiemGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TimKiemGroup.Controls.Add(this.TimKiemButton);
            this.TimKiemGroup.Controls.Add(this.TimKiemBox);
            this.TimKiemGroup.Location = new System.Drawing.Point(45, 19);
            this.TimKiemGroup.Name = "TimKiemGroup";
            this.TimKiemGroup.Size = new System.Drawing.Size(228, 91);
            this.TimKiemGroup.TabIndex = 19;
            this.TimKiemGroup.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox4.Controls.Add(this.exitButton);
            this.groupBox4.Controls.Add(this.TimKiemGroup);
            this.groupBox4.Controls.Add(this.TacVuGroup);
            this.groupBox4.Location = new System.Drawing.Point(0, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 463);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(54, 394);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(209, 39);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "Đóng Chương Trình";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 601);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ViewTab);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN";
            this.Text = "Quản Lý Bán Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADMIN_FormClosing);
            this.Load += new System.EventHandler(this.ADMIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ViewTab.ResumeLayout(false);
            this.KhachHangTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangView)).EndInit();
            this.HangHoaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaView)).EndInit();
            this.HoaDonTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBanView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TacVuGroup.ResumeLayout(false);
            this.TimKiemGroup.ResumeLayout(false);
            this.TimKiemGroup.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl ViewTab;
        private System.Windows.Forms.TabPage KhachHangTab;
        private System.Windows.Forms.TabPage HangHoaTab;
        private System.Windows.Forms.TabPage HoaDonTab;
        private System.Windows.Forms.DataGridView KhachHangView;
        private System.Windows.Forms.DataGridView HangHoaView;
        private System.Windows.Forms.DataGridView HoaDonBanView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.TextBox Box3;
        private System.Windows.Forms.TextBox Box4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox TacVuGroup;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox TimKiemBox;
        private System.Windows.Forms.Button TimKiemButton;
        private System.Windows.Forms.GroupBox TimKiemGroup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button exitButton;
    }
}

