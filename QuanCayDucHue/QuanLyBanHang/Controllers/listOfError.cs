using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHang.Controllers
{
    internal class listOfError
    {
        public static string checkError(string error)
        {
            if (error.Contains("D0CB8DDDF75B49D4"))
            {
                return "Khách Hàng Này Đã Tồn Tại";
            }
            else if (error.Contains("19C0DB1DE66B57C3"))
            {
                return "Hàng Này Đã Tồn Tại";
            }
            else if (error.Contains("BC3CAB574634AF9A"))
            {
                return "Hóa Đơn Này Đã Tồn Tại";
            }
            else if (error.Contains("CODE1"))
            {
                return "Khách Hàng Này Không Tồn Tại!";
            }
            else if (error.Contains("CODE2"))
            {
                return "Hàng Này Không Tồn Tại!";
            }
            else if (error.Contains("CODE3"))
            {
                return "Hóa Đơn Này Không Tồn Tại!";
            }
            else if (error.Contains("145C0A3F"))
            {
                return "Không Thể Xóa Khách Này Vì Khách Này Đã Tồn Tại Trong Một Hóa Đơn\n Vui Lòng Kiểm Tra lại Hóa Đơn";
            }
            else if (error.Contains("String or binary data would be truncated"))
            {
                return "Quá Số Lượng Ký Tự Cho Phép!";
            }
            else if (error.Contains("Conversion failed"))
            {
                return "Thời Gian Không Hợp Lệ!";
            }
            return error;
        }
    }
}
