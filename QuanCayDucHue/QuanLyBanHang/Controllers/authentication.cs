using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyBanHang.Controllers
{
    internal class authentication
    {
        public static bool connectionStatus;
        public static string connectionMessage;

        public static bool accessUser(string username, string password)
        {
            ADO.sqlConnection(username, password);
            return connectionStatus;
        }

        public static string filter (string rawText)
        {
            string pattern = @"[^a-zA-Z0-9\s]";
            string replacement = ""; 

            Regex regex = new Regex(pattern);
            string result = regex.Replace(rawText, replacement);

            return result;
        }
        public static string filter2(string rawText)
        {
            string pattern = @"[^a-zA-Z0-9\s,_/]";
            string replacement = "";

            Regex regex = new Regex(pattern);
            string result = regex.Replace(rawText, replacement);

            return result;
        }
        
    }
}
