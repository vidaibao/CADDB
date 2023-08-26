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
            lblInfo.Text = dBLoadUtil.LoadBlocksWithAttributes();
        }

        private void btnRetrieveLines_Click(object sender, EventArgs e)
        {
            DBRetrieveUtil dBRetrieveUtil = new DBRetrieveUtil();
            lblInfo.Text = dBRetrieveUtil.RetrieveAndDrawLines();
        }

        private void btnRetrieveMTexts_Click(object sender, EventArgs e)
        {
            DBRetrieveUtil dBRetrieveUtil = new DBRetrieveUtil();
            lblInfo.Text = dBRetrieveUtil.RetrieveAndDrawMTexts();
        }

        private void btnRetrieveDrawPLines_Click(object sender, EventArgs e)
        {
            DBRetrieveUtil dBRetrieveUtil = new DBRetrieveUtil();
            lblInfo.Text = dBRetrieveUtil.RetrieveAndDrawPLines();
        }

        private void btnRetrieveAnhDrawBlocksNoAttribute_Click(object sender, EventArgs e)
        {
            DBRetrieveUtil dBRetrieveUtil = new DBRetrieveUtil();
            lblInfo.Text = dBRetrieveUtil.RetrieveAndDrawBlocksNoAttribute();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBRetrieveUtil dBRetrieveUtil = new DBRetrieveUtil();
            lblInfo.Text = dBRetrieveUtil.RetrieveAndDrawBlocksWithAttributes();
        }

        private void btnUpdateLines_Click(object sender, EventArgs e)
        {
            DBUpdateUtil dBUpdateUtil = new DBUpdateUtil();
            lblInfo.Text = dBUpdateUtil.UpdateLines();
        }

        private void btnDeleteLines_Click(object sender, EventArgs e)
        {
            DBDeleteUtil dBDeleteUtil = new DBDeleteUtil();
            lblInfo.Text = dBDeleteUtil.DeleteLines();
        }

        private void btnDeleteMTexts_Click(object sender, EventArgs e)
        {
            DBDeleteUtil dbDeleteUtil = new DBDeleteUtil();
            lblInfo.Text = dbDeleteUtil.DeleteMTexts();
        }

        private void btnDeletePLines_Click(object sender, EventArgs e)
        {
            DBDeleteUtil dBDeleteUtil = new DBDeleteUtil();
            lblInfo.Text = dBDeleteUtil.DeletePlines();
        }

        private void btnDeleteBlocksNoAttribute_Click(object sender, EventArgs e)
        {
            DBDeleteUtil dBDeleteUtil = new DBDeleteUtil();
            lblInfo.Text = dBDeleteUtil.DeleteBlocksNoAttribute();
        }

        private void btnDeleteBlocksWithAttributes_Click(object sender, EventArgs e)
        {
            DBDeleteUtil dBDeleteUtil = new DBDeleteUtil();
            lblInfo.Text = dBDeleteUtil.DeleteBlocksWithAttributes();
        }
    }
}
