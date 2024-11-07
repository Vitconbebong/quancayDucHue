using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Controllers
{
    internal class HangQuery
    {
        #region GET ALL DATAS
        public static DataTable getAllHang()
        {
            string allData = "SELECT * FROM DMHang";
            return ADO.dataTable(allData);
        }
        #endregion

        #region GET ALL DATAS WITH CONDITION
        public static DataTable getSelectedHang(string Hang)
        {
            string query = $@"SELECT * 
                              FROM DMHang
                              WHERE MaHang = '{Hang}' OR 
                                    Tenhang LIKE N'%{Hang}%'";
            return ADO.dataTable(query);
        }
        #endregion

        #region INSERT
        public static void addNewHang(string MaHang, string TenHang, string DVT, string NOISX)
        {
            string query = $@"INSERT INTO DMHang VALUES 
                              ('{MaHang}', N'{TenHang}', N'{DVT}', '{NOISX}')";
            ADO.executeQuery(query);
        }
        #endregion

        #region UPDATE
        public static void updateHang(string MaHang, string TenHang, string DVT, string NOISX)
        {
            string query = $@"UPDATE DMHang
                             SET TenHang = N'{TenHang}',
                                 DVT = N'{DVT}',
                                 NOI_SX = N'{NOISX}'
                             WHERE MaHang = '{MaHang}'";
            ADO.executeQuery(query);
        }
        #endregion

        #region DELETE
        public static void deleteHang(string MaHang)
        {
            string query = $@"DELETE FROM DMHang
                                WHERE  MaHang = '{MaHang}'";
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
                    return text != "" && text.Length < 11 ? true : false;
                case 2:
                    return text != "" && text.Length < 21 ? true : false;
                case 3:
                    return text != "" && text.Length < 26 ? true : false;
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
                        return text == "" ? "Không Được Để Trống" : "Tối Đa 11 Ký Tự!";
                    case 2:
                        return text == "" ? "Không Được Để Trống" : "Tối Đa 21 Ký Tự!";
                    case 3:
                        return text == "" ? "Không Được Để Trống" : "Tối Đa 25 Ký Tự!";
                }
            }
            return null;
        }
        #endregion
    }

}
