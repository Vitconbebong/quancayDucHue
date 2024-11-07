using QuanLyBanHang.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;


namespace QuanLyBanHang
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            Coverer.BackColor = Color.FromArgb(100, Color.Black);
            label1.BackColor = Color.FromArgb(0, Color.Black);
            label2.BackColor = Color.FromArgb(0, Color.Black);
            ShowError.BackColor = Color.FromArgb(0, Color.Black);
            

        }


        private async void DangNhapButton_Click(object sender, EventArgs e)
        {
            if (checkInfor())
            {
                this.Close();
            }
            else
            {
                if (authentication.connectionMessage.Contains("Chi Tiết"))
                {
                    MessageBox.Show(
                        authentication.connectionMessage, "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
                else
                {
                    ShowError.Text = authentication.connectionMessage;
                    await Task.Delay(5000);
                    ShowError.Text = "";
                }
            }
        }

        public bool checkInfor()
        {

            return authentication.accessUser(authentication.filter(TenDangNhapBox.Text), authentication.filter(MatKhauBox.Text));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Hãy Nhớ Lại Mật Khẩu Đã Quên", "Thông Báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }

}