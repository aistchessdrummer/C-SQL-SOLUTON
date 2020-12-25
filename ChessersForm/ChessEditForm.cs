using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessersLibrary;

namespace ChessersForm
{
    public partial class ChessEditForm : Form
    {
        public ChesserInfo _newCheeser = new ChesserInfo();
        public ChessEditForm()
        {
            InitializeComponent();
        }

        private void ChessEditForm_Load(object sender, EventArgs e)
        {
            SexList _sexList = SexList.GetDefaultSexList();
            sexlistbindingSource.DataSource = _sexList;

            ZvanRazList _zvanRazList = ZvanRazList.GetDefaultZvanRazList();
            zvanrazbindingSource.DataSource = _zvanRazList;

            chesserInfoBindingSource.DataSource = _newCheeser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_newCheeser.ChesserID > 0)
            {
                _newCheeser.UpdateChesser();
            }
            else
            {
                _newCheeser.InsertNewChesser();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
