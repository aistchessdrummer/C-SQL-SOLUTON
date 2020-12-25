using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ChessersLibrary
{
    public class SexInfo
    {
        private int _sexID = 0;
        private string _sex = "";

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
    }
}