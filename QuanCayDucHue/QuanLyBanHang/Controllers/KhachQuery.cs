using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Controllers
{
    internal class KhachQuery
    {

        #region GET ALL DATAS
        public static DataTable getAllKhach()
        {
            string allData = "SELECT * FROM DMKhach";
            return ADO.dataTable(allData);
        }
        #endregion

        #region Get ALL DATAS with CONDITION
        public static DataTable getSeletedKhach(string Khach)
        {
            string query = $@"SELECT * 
                              FROM DMKhach 
                              WHERE MaKhach = '{Khach}' OR 
                                    TenKhach LIKE N'%{Khach}%'  ";
            return ADO.dataTable(query);
        }
        #endregion

        #region INSERT
        public static void addNewKhach(string MaKhach, string TenKhach, string QueQuan, string DienThoai)
        {
            string query = $@"INSERT INTO DMKhach VALUES 
                              ('{MaKhach}', N'{TenKhach}', N'{QueQuan}', '{DienThoai}')";
            ADO.executeQuery(query);
        }
        #endregion

        #region UPDATE
        public static void updateKhach(string MaKhach, string TenKhach, string QueQuan, string DienThoai)
        {
            string query = $@"UPDATE DMKhach
                             SET TenKhach = N'{TenKhach}',
                                 QueQuan = N'{QueQuan}',
                                 DienThoai = '{DienThoai}'
                             WHERE MaKhach = '{MaKhach}'";
            ADO.executeQuery(query);
        }
        #endregion

        #region DELETE
        public static void deleteKhach(string MaKhach)
        {
            string query = $@"DELETE FROM DMKhach
                                WHERE  MaKhach = '{MaKhach}'";
            ADO.executeQuery(query);
        }
        #endregion

        #region CHECK VALUED INFOR
        public static bool checkInfor(string text, int index)
        {
            switch (index)
            {
                case 0:
                    return text != "" && text.Length < 16 ? true : false;
                case 1:
                    return text != "" && text.Length < 21 ? true : false;
                case 2:
                    return text != "" && text.Length < 26 ? true : false;
                case 3:
                    return text != "" && text.Length < 12 && int.TryParse(text,out int a)&& a>0 ? true : false;
                default: return false;
            }
        }

        public static string showError(string text, int index)
        {
            if(!checkInfor(text, index))
            {
                switch (index)
                {
                    case 0:
                        return text == "" ? "Không Được Để Trống" : "Tối Đa 15 Ký Tự!";
                    case 1:
                        return text == "" ? "Không Được Để Trống" : "Tối Đa 20 Ký Tự!";
                    case 2:
                        return text == "" ? "Không Được Để Trống" : "Tối Đa 26 Ký Tự!";
                    case 3:
                        int a;
                        if (text == "")
                            return "Không Được Để Trống";
                        else if (text.Length > 11)
                            return "Tối Đa 11 Ký Tự";
                        else if (!int.TryParse(text, out a))
                            return "Đây Không Phải Số";
                        else if (a < 0)
                            return "Số Điện Thoại Không Thể Âm!";
                        else return null;
                }
            }
            return null;
        }
        #endregion
    }
}
