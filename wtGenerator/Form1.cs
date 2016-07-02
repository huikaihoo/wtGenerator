using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wtGenerator
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            List<string> batchIdList = new List<string>(
                tbBatchId.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));

            List<string> batchUrlList = new List<string>( 
                tbBatchUrl.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries) );

            int listCnt = Math.Min(batchIdList.Count, batchUrlList.Count);

            for (int i = 0; i < listCnt; i++)
            {
                if (batchIdList[i] != "" && batchUrlList[i] != "")
                {
                    Worker.GenerateHtml(batchIdList[i], new ImgSrc(batchUrlList[i]), 28);
                    Worker.DownloadImg(batchIdList[i], new ImgSrc(batchUrlList[i]), 40);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            List<string> batchIdList = new List<string>(
                tbBatchId.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));

            List<string> batchUrlList = new List<string>(
                tbBatchUrl.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));

            int listCnt = Math.Min(batchIdList.Count, batchUrlList.Count);

            for (int i = 0; i < listCnt; i++)
            {
                if (batchIdList[i] != "" && batchUrlList[i] != "")
                {
                    Worker.SearchImg(batchIdList[i], new ImgSrc(batchUrlList[i]), 40);
                }
            }
        }
    }
}
