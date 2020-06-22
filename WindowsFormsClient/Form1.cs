using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsClient.WCFService;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            // 所產生出來的Proxy物件
            ServiceClient sc = new ServiceClient();
            float StockPrice = sc.GetStockPrice(11234);
            MessageBox.Show(StockPrice.ToString("C"));
            sc.Close();
        }
    }
}
