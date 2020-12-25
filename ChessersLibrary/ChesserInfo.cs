using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ChessersLibrary
{
    public class ChesserInfo
    {
        private int _chesserID = 0;
        private string _chesser = "";
        private int _chesserRaiting = 0;
        private DateTime _chesserDateBirth = DateTime.Today;
        private int _sexID = 0;
        private string _sex = "";
        private int _zvanRazID = 0;
        private string _zvanRaz = "";
        public int SexID
        {
            get
            {
                return _sexID;
            }
            set
            {
                _sexID = value;
            }
        }
        public string Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }
        }
        public int ZvanRazID
        {
            get
            {
                return _zvanRazID;
            }
            set
            {
                _zvanRazID = value;
            }
        }
        public string ZvanRaz
        {
            get
            {
                return _zvanRaz;
            }
            set
            {
                _zvanRaz = value;
            }
        }

        public int ChesserID
        {
            get
            {
                return _chesserID;
            }
            set
            {
                _chesserID = value;
            }
        }
        public string Chesser
        {
            get
            {
                return _chesser;
            }
            set
            {
                _chesser = value;
            }
        }

        public int ChesserRaiting
        {
            get
            {
                return _chesserRaiting;
            }
            set
            {
                _chesserRaiting = value;
            }
        }

        public DateTime ChesserDateBirth
        {
            get
            {
                return _chesserDateBirth;
            }
            set
            {
                _chesserDateBirth = value;
            }
        }

        public int ChesserAge
        {
            get
            {
                return DateTime.Today.Year - _chesserDateBirth.Year;
            }
            set
            {
            }
        }

        public void InsertNewChesser()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = KOMPYKTERA\SQLEXPRESS;Initial Catalog = ChesserDB; Integrated Security = True";
            cn.Open();
            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertChesser";

            cm.Parameters.Add(new SqlParameter("@Chesser", _chesser));
            cm.Parameters.Add(new SqlParameter("@Raiting", _chesserRaiting));
            cm.Parameters.Add(new SqlParameter("@ChesserDateBirth", _chesserDateBirth));
            cm.Parameters.Add(new SqlParameter("@SexID", _sexID));
            cm.Parameters.Add(new SqlParameter("@ZvanRazID", _zvanRazID));
            cm.ExecuteNonQuery();
        }
        public void DeleteChesser()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = KOMPYKTERA\SQLEXPRESS;Initial Catalog = ChesserDB; Integrated Security = True";
            cn.Open();
            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteChesser";

            cm.Parameters.Add(new SqlParameter("@ChesserID", _chesserID));

            cm.ExecuteNonQuery();
        }
        public void UpdateChesser()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = KOMPYKTERA\SQLEXPRESS;Initial Catalog = ChesserDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateChesser";

            cm.Parameters.Add(new SqlParameter("@ChesserID", _chesserID));
            cm.Parameters.Add(new SqlParameter("@Chesser", _chesser));
            cm.Parameters.Add(new SqlParameter("@ChesserDateBirth", _chesserDateBirth));
            cm.Parameters.Add(new SqlParameter("@Raiting", _chesserRaiting));
            cm.Parameters.Add(new SqlParameter("@SexID", _sexID));
            cm.Parameters.Add(new SqlParameter("@ZvanRazID", _zvanRazID));

            cm.ExecuteNonQuery();
        }
        public void GetChesser(int chesserID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = KOMPYKTERA\SQLEXPRESS;Initial Catalog = ChesserDB; Integrated Security = True";
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "GetChesser";

            cm.Parameters.Add(new SqlParameter("@ChesserID", _chesserID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                _chesserID = (int)dr["ChesserID"];
                _chesser = dr["Chesser"].ToString();
                _chesserRaiting = (int)dr["Raiting"];
                _chesserDateBirth = (DateTime)dr["ChesserDateBirth"];
                _sexID = (int)dr["SexID"];
                _sex = dr["Sex"].ToString();
                _zvanRazID = (int)dr["ZvanRazID"];
                _zvanRaz = dr["ZvanRaz"].ToString();
            }

        }
    }
}