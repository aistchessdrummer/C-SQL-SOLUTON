using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ChessersLibrary
{
    public class ZvanRazInfo
    {
        private int _zvanRazID = 0;
        private string _zvanRaz = "";

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
    }
}