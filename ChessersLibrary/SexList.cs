using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ChessersLibrary
{
    public class SexList : List<SexInfo>
    {
        public static SexList GetDefaultSexList()
        {
            SexList myList = new SexList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = KOMPYKTERA\SQLEXPRESS;Initial Catalog = ChesserDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetSexList";

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                SexInfo newSex = new SexInfo();
                newSex.SexID = (int)dr["SexID"];
                newSex.Sex = dr["Sex"].ToString();
                myList.Add(newSex);
            }
            return myList;
        }
    }
}