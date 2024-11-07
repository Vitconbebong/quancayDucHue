using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Controllers
{
    internal class HoaDonQuery
    {
        #region GET ALL DATAS
        public static DataTable getAllHoaDon()
        {
            string allData = @"SELECT SoHD, MaKhach , CONVERT(VARCHAR, NgayHD, 103) AS NgayHD, DienGiai 
                                FROM HoaDonBan";
            return ADO.dataTable(allData);
        }
        #endregion

        #region GET ALL DATAS WITH CONDITION
        public static DataTable getSelectedHoaDon(string HoaDon)
        {
            string query = $@"SELECT SoHD, MaKhach , CONVERT(VARCHAR, NgayHD, 103) AS NgayHD, DienGiai 
                              FROM HoaDonBan
                              WHERE SoHD = '{HoaDon}'";
            return HoaDon!=""? ADO.dataTable(query): getAllHoaDon();
        }
        #endregion

        #region INSERT
        public static void addNewHoaDon(string SoHD, string MaKhach, string NgayHD, string DienGiai)
        {
            string query = $@"INSERT INTO HoaDonBan VALUES 
                              ('{SoHD}', N'{MaKhach}', N'{NgayHD}', N'{DienGiai}')";
            ADO.executeQuery(query);
        }
        #endregion

        #region UPDATE
        public static void updateHoaDon(string SoHD, string MaKhach, string NgayHD, string DienGiai)
        {
            string query = $@"UPDATE HoaDonBan
                             SET MaKhach = '{MaKhach}',
                                 NgayHD = '{NgayHD}',
                                 DienGiai = N'{DienGiai}'
                             WHERE SoHD = '{SoHD}'";
            ADO.executeQuery(query);
        }
        #endregion

        #region DELETE
        public static void deleteHoaDon(string SoHD)
        {
            string query = $@"DELETE FROM HoaDonBan
                                WHERE  SoHD = '{SoHD}'";
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
                    return text != "" && text.Length < 16 ? true : false;
                case 2:
                    return text != "" && text.Length < 11 && DateTime.TryParse(text,out DateTime a) ? true : false;
                case 3:
                    return text != "" && text.Length < 16 ? true : false;
                default: return false;
            }
        }

        public static string showError(string text, int index)
        {
            if (!checkInfor(text, index))
            {
                switch (index)
                {
                    case 0:
                        return text == "" ? "Không Được Để Trống" : "Tối Đa 15 Ký Tự!";
                    case 1:
                        return text == "" ? "Không Được Để Trống" : "Tối Đa 15 Ký Tự!";
                    case 2:
                        return text == "" ? "Không Được Để Trống" : "Thời Gian Không Hợp Lệ";
                    case 3:
                        return text == "" ? "Không Được Để Trống" : "Tối Đa 15 Ký Tự!";
                }
            }
            return null;
        }
        #endregion
    }

}
