using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace WebBanHangOnline.Models.Commons
{
    public class ThongKeTruyCap
    {
        private static string strConnect = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        public static ThongKeViewModel ThongKe()
        {
            using(var connect = new SqlConnection(strConnect))
            {
                var item = connect.QueryFirstOrDefault<ThongKeViewModel>("sp_Thongkee", commandType: CommandType.StoredProcedure);
                return item;
            }
        }
    }
}