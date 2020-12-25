using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ChessersLibrary
{
    public class ZvanRazList : List<ZvanRazInfo>
    {
        public static ZvanRazList GetDefaultZvanRazList()
        {
            ZvanRazList myList = new ZvanRazList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = KOMPYKTERA\SQLEXPRESS;Initial Catalog = ChesserDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetZvanRazList";

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                ZvanRazInfo newZvanRaz = new ZvanRazInfo();
                newZvanRaz.ZvanRazID = (int)dr["ZvanRazID"];
                newZvanRaz.ZvanRaz = dr["ZvanRaz"].ToString();
                myList.Add(newZvanRaz);

            }
            return myList;
        }
    }
}