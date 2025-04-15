
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaMarketProApp.Extensions;
using WaMarketProApp.Utils;

namespace WaMarketProApp
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            new FrmMain().ShowDialog();
        }
    }
}
