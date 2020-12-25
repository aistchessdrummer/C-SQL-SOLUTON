using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChessersLibrary
{
    public class ChesserList : List<ChesserInfo>
    {
        public static ChesserList GetDefaultChesserList()
        {
            ChesserList myList = new ChesserList();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = KOMPYKTERA\SQLEXPRESS;Initial Catalog = ChesserDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetChesserList";

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
             {
                ChesserInfo newChesser = new ChesserInfo();
                newChesser.ChesserID = (int)dr["ChesserID"];
                newChesser.Chesser = dr["Chesser"].ToString();
                newChesser.ChesserRaiting = (int)dr["Raiting"];
                newChesser.ChesserDateBirth = (DateTime)dr["ChesserDateBirth"];
                newChesser.SexID = (int)dr["SexID"];
                newChesser.Sex = dr["Sex"].ToString();
                newChesser.ZvanRazID = (int)dr["ZvanRazID"];
                newChesser.ZvanRaz = dr["ZvanRaz"].ToString();
                myList.Add(newChesser);

             }

            return myList;
        }
    }
}
