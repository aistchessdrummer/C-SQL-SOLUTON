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
    public partial class ChessForm : Form
    {
        ChesserList _chesserList = new ChesserList();
        public ChessForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh_();
        }

        private void ChessForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChessEditForm newForm = new ChessEditForm();

            newForm.ShowDialog();
            Refresh_();
        }
        void Refresh_()
        {
            _chesserList = ChesserList.GetDefaultChesserList();
            chesserListBindingSource.DataSource = null;
            chesserListBindingSource.DataSource = _chesserList;
            _chesserList = ChesserList.GetDefaultChesserList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cheID = (int)chesserListDataGridView.SelectedRows[0].Cells[0].Value;

            foreach (ChesserInfo chesser in _chesserList)
            {
                if (chesser.ChesserID == cheID)
                {
                    chesser.DeleteChesser();
                }
            }
            Refresh_();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cheID = (int)chesserListDataGridView.SelectedRows[0].Cells[0].Value;

            ChessEditForm newForm = new ChessEditForm();

            foreach (ChesserInfo chesser in _chesserList)
            {
                if (chesser.ChesserID == cheID)
                {
                    chesser.GetChesser(cheID);
                    newForm._newCheeser = chesser;
                    if (newForm.ShowDialog() == DialogResult.OK)
                    {
                        newForm._newCheeser.UpdateChesser();
                    }
                }
            }
            Refresh_();
        }
    }
}