using QuanLyBanHang.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBanHang
{
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
            TimKiemGroup.BackColor = Color.FromArgb(150, Color.Aquamarine);
            TacVuGroup.BackColor = Color.FromArgb(250, Color.LemonChiffon);
        }



        private void ADMIN_Load(object sender, EventArgs e)
        {
            #region SHOW ALL DATA
            KhachHangView.DataSource = KhachQuery.getAllKhach();
            HangHoaView.DataSource = HangQuery.getAllHang();
            HoaDonBanView.DataSource = HoaDonQuery.getAllHoaDon();
            #endregion

            #region RENAME KHACHHANG TABLE COLUMN NAME
            KhachHangView.Columns["MaKhach"].HeaderText = "Mã Khách";
            KhachHangView.Columns["TenKhach"].HeaderText = "Tên Khách";
            KhachHangView.Columns["QueQuan"].HeaderText = "Quê Quán";
            KhachHangView.Columns["DienThoai"].HeaderText = "Số Điện Thoại";
            #endregion

            #region RENAME HANGHOA TABLE COLUMN NAME
            HangHoaView.Columns["MaHang"].HeaderText = "Mã Hàng";
            HangHoaView.Columns["TenHang"].HeaderText = "Tên Hàng";
            HangHoaView.Columns["DVT"].HeaderText = "Đơn Vị Tính";
            HangHoaView.Columns["NOI_SX"].HeaderText = "Nơi Sản Xuất";
            #endregion

            #region RENAME HOADON TABLE COLUMN NAME
            HoaDonBanView.Columns["SoHD"].HeaderText = "Số Hóa Đơn";
            HoaDonBanView.Columns["MaKhach"].HeaderText = "Mã Khách";
            HoaDonBanView.Columns["NgayHD"].HeaderText = "Ngày Lập Hóa Đơn";
            HoaDonBanView.Columns["DienGiai"].HeaderText = "Mô Tả";
            #endregion

            previewTextBox();// call preview textbox function
            ViewTab_SelectedIndexChanged(sender, e);
        }

        #region PREVIEW SEARCH BOX
        // CHANGE CONTENT IN SEARCH BOX
        private void previewTextBox()
        {
            switch (ViewTab.SelectedIndex)
            {
                case 0:
                    TimKiemBox.Text = "Nhập Mã Khách Hoặc Tên Khách";
                    TimKiemBox.ForeColor = Color.Gray;
                    break;
                case 1:
                    TimKiemBox.Text = "Nhập Mã Hàng Hoặc Tên Hàng";
                    TimKiemBox.ForeColor = Color.Gray;
                    break;
                case 2:
                    TimKiemBox.Text = "Nhập Mã Hóa Đơn";
                    TimKiemBox.ForeColor = Color.Gray;
                    break;
            }
        }

        // WHEN ENTERING IN THE SEARCH BOX
        private void TimKiemBox_Enter(object sender, EventArgs e)
        {
            if (TimKiemBox.Text.Contains("Nhập Mã"))
            {
                TimKiemBox.Text = "";
                TimKiemBox.ForeColor = SystemColors.WindowText;
            }
        }


        // WHEN LEAVING THE SEARCH BOX
        private void TimKiemBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TimKiemBox.Text))
            {
                previewTextBox();
            }
        }

        #endregion


        #region Search INFORMATION
        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string query = TimKiemBox.Text;
            if (query.Contains("Nhập Mã")) query = "";
            switch (ViewTab.SelectedIndex)
            {
                case 0: KhachHangView.DataSource = KhachQuery.getSeletedKhach(authentication.filter2(query));
                    break;
                case 1: HangHoaView.DataSource = HangQuery.getSelectedHang(authentication.filter2(query));
                    break;
                case 2: HoaDonBanView.DataSource = HoaDonQuery.getSelectedHoaDon(authentication.filter2(query));
                    break;
            }
        }


        #endregion


        #region SHOW DATA FROM TABLE TO TEXTBOX
        private void KhachHangView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            Box1.Text = KhachHangView.Rows[e.RowIndex].Cells[0].Value.ToString().TrimEnd();
            Box2.Text = KhachHangView.Rows[e.RowIndex].Cells[1].Value.ToString().TrimEnd();
            Box3.Text = KhachHangView.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd();
            Box4.Text = KhachHangView.Rows[e.RowIndex].Cells[3].Value.ToString().TrimEnd();

            DeleteButton.Enabled = true;
            UpdateButton.Enabled = true;
        }

        private void HangHoaView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            Box1.Text = HangHoaView.Rows[e.RowIndex].Cells[0].Value.ToString().TrimEnd();
            Box2.Text = HangHoaView.Rows[e.RowIndex].Cells[1].Value.ToString().TrimEnd();
            Box3.Text = HangHoaView.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd();
            Box4.Text = HangHoaView.Rows[e.RowIndex].Cells[3].Value.ToString().TrimEnd();

            DeleteButton.Enabled = true;
            UpdateButton.Enabled = true;
        }

        private void HoaDonBanView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            Box1.Text = HoaDonBanView.Rows[e.RowIndex].Cells[0].Value.ToString().TrimEnd();
            Box2.Text = HoaDonBanView.Rows[e.RowIndex].Cells[1].Value.ToString().TrimEnd();
            Box3.Text = HoaDonBanView.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd();
            Box4.Text = HoaDonBanView.Rows[e.RowIndex].Cells[3].Value.ToString().TrimEnd();

            DeleteButton.Enabled = true;
            UpdateButton.Enabled = true;
        }

        #endregion


        #region Change TEXT OF TEXTBOX BASE ON SELECTED TAB
        private void ViewTab_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (ViewTab.SelectedIndex)
            {
                case 0:
                    label2.Text = "Mã Khách";
                    label3.Text = "Tên Khách";
                    label4.Text = "Quê Quán";
                    label5.Text = "Điện Thoại";
                    previewTextBox(); //change the preview text in searching textbox
                    break;
                case 1:
                    label2.Text = "Mã Hàng";
                    label3.Text = "Tên Hàng";
                    label4.Text = "Đơn Vị";
                    label5.Text = "Sản Xuất";
                    previewTextBox(); //change the preview text in searching textbox
                    break;
                case 2:
                    label2.Text = "Số Hóa Đơn";
                    label3.Text = "Mã Khách ";
                    label4.Text = "Ngày Lập";
                    label5.Text = "Mô Tả";
                    previewTextBox(); //change the preview text in searching textbox
                    break;
            }
        }

        #endregion


        #region "Thêm" BUTTON IS CLICKED
        private void AddButton_Click(object sender, EventArgs e)
        {
            Box1.Enabled = true;
            Box2.Enabled = true;
            Box3.Enabled = true;
            Box4.Enabled = true;

            TimKiemButton.Enabled = false;
            AddButton.Enabled = false;

            UpdateButton.Visible = false;
            DeleteButton.Visible = false;
            SaveButton.Visible = true;
            cancelButton.Visible = true;

        }
        #endregion


        #region "Lưu" BUTTON IS CLICKED
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                #region FOR SAVE THE INSERTED INFORMATION
                if(AddButton.Visible)
                    switch (ViewTab.SelectedIndex)
                    {
                        case 0:
                            KhachQuery.addNewKhach(authentication.filter2(Box1.Text), authentication.filter( Box2.Text), authentication.filter2( Box3.Text), authentication.filter( Box4.Text));
                            KhachHangView.DataSource = KhachQuery.getAllKhach();
                            showMessageBox($"Đã Thêm Thành Công", "Thông Báo", "notify");
                            break;
                        case 1:
                            HangQuery.addNewHang(authentication.filter2(Box1.Text), authentication.filter(Box2.Text), authentication.filter(Box3.Text), authentication.filter2(Box4.Text));
                            HangHoaView.DataSource = HangQuery.getAllHang();
                            showMessageBox($"Đã Thêm Thành Công", "Thông Báo", "notify");
                            break;
                        case 2:
                            HoaDonQuery.addNewHoaDon(authentication.filter(Box1.Text), authentication.filter2(Box2.Text), authentication.filter2(Box3.Text), authentication.filter(Box4.Text));
                            HoaDonBanView.DataSource = HoaDonQuery.getAllHoaDon();
                            showMessageBox($"Đã Thêm Thành Công", "Thông Báo", "notify");
                            break;
                    }
                #endregion


                #region FOR SAVE THE UPDATED INFORMATION
                else
                    switch (ViewTab.SelectedIndex)
                    {
                        case 0:
                            KhachQuery.updateKhach(authentication.filter2(Box1.Text), authentication.filter(Box2.Text), authentication.filter2(Box3.Text), authentication.filter(Box4.Text));
                            KhachHangView.DataSource = KhachQuery.getAllKhach();
                            showMessageBox($"Đã Sửa Thành Công", "Thông Báo", "notify");
                            break;
                        case 1:
                            HangQuery.updateHang(authentication.filter2(Box1.Text), authentication.filter(Box2.Text), authentication.filter(Box3.Text), authentication.filter2(Box4.Text));
                            HangHoaView.DataSource = HangQuery.getAllHang();
                            showMessageBox($"Đã Sửa Thành Công", "Thông Báo", "notify");
                            break;
                        case 2:
                            HoaDonQuery.updateHoaDon(authentication.filter(Box1.Text), authentication.filter2(Box2.Text), authentication.filter2(Box3.Text), authentication.filter(Box4.Text));
                            HoaDonBanView.DataSource = HoaDonQuery.getAllHoaDon();
                            showMessageBox($"Đã Sửa Thành Công", "Thông Báo", "notify");
                            break;
                    }
                #endregion

            }
            catch (Exception ex)
            {
                showMessageBox(listOfError.checkError(ex.Message), "Lỗi", "error");
            }
        }
        #endregion


        #region SHOW MESSAGE BOX
        private bool showMessageBox(string message, string title, string type)
        {
            switch (type)
            {
                case "caution":
                    MessageBox.Show(
                        message, title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                    break;

                case "error":
                    MessageBox.Show(
                        message, title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    break;

                case "notify":
                    MessageBox.Show(
                        message, title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk
                        );
                    break;

                default:
                    DialogResult r = MessageBox.Show(
                        message, title,
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question
                        );
                    return r == DialogResult.OK?true:false;
            }
            return false;
        }
        #endregion


        #region CONTROL OTHER TABS WHEN INSERTING OR UPDATING
        private void ViewTab_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(SaveButton.Visible)
                e.Cancel = true;
        }
        #endregion


        #region "Hủy" BUTTON IS CLICKED
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Box1.Enabled = false;
            Box2.Enabled = false;
            Box3.Enabled = false;
            Box4.Enabled = false;

            TimKiemButton.Enabled = true;
            AddButton.Enabled = true;
            UpdateButton.Enabled = true;

            UpdateButton.Location = new Point(18, 91);


            AddButton.Visible = true;
            UpdateButton.Visible = true;
            DeleteButton.Visible = true;
            SaveButton.Visible = false;
            cancelButton.Visible = false;
        }
        #endregion


        #region "Sửa" BUTTON IS CLICKED
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Box2.Enabled = true;
            Box3.Enabled = true;
            Box4.Enabled = true;

            UpdateButton.Location = new Point(18, 25);

            TimKiemButton.Enabled = false;
            UpdateButton.Enabled = false;

            AddButton.Visible = false;
            DeleteButton.Visible = false;
            SaveButton.Visible = true;
            cancelButton.Visible = true;
        }
        #endregion


        #region "Xóa" BUTTON IS CLICKED
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            switch (ViewTab.SelectedIndex)
            {
                case 0:
                    if(showMessageBox($"Bạn Có Chắc Chắn Muốn Xóa Khách {Box1.Text} Không?", "Xác Minh", "Verify")){
                        KhachQuery.deleteKhach(Box1.Text);
                        KhachHangView.DataSource = KhachQuery.getAllKhach();
                        showMessageBox("Xóa Thành Công", "Thông Báo", "caution");
                    }
                    break;
                case 1:
                    if (showMessageBox($"Bạn Có Chắc Chắn Muốn Xóa Hàng {Box1.Text} Không?", "Xác Minh", "Verify"))
                    {
                        HangQuery.deleteHang(Box1.Text);
                        HangHoaView.DataSource = HangQuery.getAllHang();
                        showMessageBox("Xóa Thành Công", "Thông Báo", "caution");
                    }
                    break;
                case 2:
                    if (showMessageBox($"Bạn Có Chắc Chắn Muốn Xóa Hóa Đơn {Box1.Text} Không?", "Xác Minh", "Verify"))
                    {
                        HoaDonQuery.deleteHoaDon(Box1.Text);
                        HoaDonBanView.DataSource = HoaDonQuery.getAllHoaDon();
                        showMessageBox("Xóa Thành Công", "Thông Báo", "caution");
                    }
                    break;
            }
               
                    
        }
        #endregion


        #region CHECK VALUED INFO
        private void Box1_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            switch (ViewTab.SelectedIndex)
            {
                case 0:
                    if (KhachQuery.showError(control.Text, 0) == null) 
                        errorProvider1.Clear();
                    else errorProvider1.SetError(control, KhachQuery.showError(control.Text, 0));
                    break;
                case 1:
                    if (HangQuery.showError(control.Text, 0) == null)
                        errorProvider1.Clear();
                    else errorProvider1.SetError(control, HangQuery.showError(control.Text, 0));
                    break;
                case 2:
                    if (HoaDonQuery.showError(control.Text, 0) == null)
                        errorProvider1.Clear();
                    else errorProvider1.SetError(control, HoaDonQuery.showError(control.Text, 0));
                    break;
            }
        }

        private void Box2_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            switch (ViewTab.SelectedIndex)
            {
                case 0:
                    if (KhachQuery.showError(control.Text, 1) == null)
                        errorProvider2.Clear();
                    else errorProvider2.SetError(control, KhachQuery.showError(control.Text, 1));
                    break;
                case 1:
                    if (HangQuery.showError(control.Text, 1) == null)
                        errorProvider2.Clear();
                    else errorProvider2.SetError(control, HangQuery.showError(control.Text, 1));
                    break;
                case 2:
                    if (HoaDonQuery.showError(control.Text, 1) == null)
                        errorProvider2.Clear();
                    else errorProvider2.SetError(control, HoaDonQuery.showError(control.Text, 1));
                    break;
            }
        }

        private void Box3_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            switch (ViewTab.SelectedIndex)
            {
                case 0:
                    if (KhachQuery.showError(control.Text, 2) == null)
                        errorProvider3.Clear();
                    else errorProvider3.SetError(control, KhachQuery.showError(control.Text, 2));
                    break;
                case 1:
                    if (HangQuery.showError(control.Text, 2) == null)
                        errorProvider3.Clear();
                    else errorProvider3.SetError(control, HangQuery.showError(control.Text, 2));
                    break;
                case 2:
                    if (HoaDonQuery.showError(control.Text, 2) == null)
                        errorProvider3.Clear();
                    else errorProvider3.SetError(control, HoaDonQuery.showError(control.Text, 2));
                    break;
            }
        }

        private void Box4_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            switch (ViewTab.SelectedIndex)
            {
                case 0:
                    if (KhachQuery.showError(control.Text, 3) == null)
                        errorProvider4.Clear();
                    else errorProvider4.SetError(control, KhachQuery.showError(control.Text, 3));
                    break;
                case 1:
                    if (HangQuery.showError(control.Text, 3) == null)
                        errorProvider4.Clear();
                    else errorProvider4.SetError(control, HangQuery.showError(control.Text, 3));
                    break;
                case 2:
                    if (HoaDonQuery.showError(control.Text, 3) == null)
                        errorProvider4.Clear();
                    else errorProvider4.SetError(control, HoaDonQuery.showError(control.Text, 3));
                    break;
            }
        }
        #endregion


        #region CLOSE PROCESS
        private void ADMIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!showMessageBox("Bạn Có Muốn Đóng Chương Trình Không", "Thông Báo", null))
                e.Cancel = true;
        }
        #endregion


        #region "Đóng Chương Trình" BUTTON IS CLICKED
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
