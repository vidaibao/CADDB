using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADDB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnLoadLines_Click(object sender, EventArgs e)
        {
            DBLoadUtil dBLoadUtil = new DBLoadUtil();
            lblInfo.Text = dBLoadUtil.LoadLines();
        }

        
        private void btnLoadMText_Click(object sender, EventArgs e)
        {
            DBLoadUtil dBLoadUtil = new DBLoadUtil();
            lblInfo.Text = dBLoadUtil.LoadMTexts();
        }

        private void btnLoadPlines_Click(object sender, EventArgs e)
        {
            DBLoadUtil dBLoadUtil = new DBLoadUtil();
            lblInfo.Text = dBLoadUtil.LoadPolyLines();
        }

        private void btnLoadBlockNoAttribute_Click(object sender, EventArgs e)
        {
            DBLoadUtil dBLoadUtil = new DBLoadUtil();
            lblInfo.Text = dBLoadUtil.LoadBlocksNoAttribute();
        }

        private void btnLoadBlocksWithAttributes_Click(object sender, EventArgs e)
        {
            DBLoadUtil dBLoadUtil = new DBLoadUtil();
            lblInfo.Text = dBLoadUtil.LoadBlocksWithAttribute();
        }
    }
}
