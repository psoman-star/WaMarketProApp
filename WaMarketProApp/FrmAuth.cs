using Krypton.Toolkit;
using Sqlite.Db;
using Sqlite.Db.Model;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using WaMarketProApp.Utils;

namespace WaMarketProApp
{
    public partial class FrmAuth : KryptonForm
    {
        private Repository<LicenseModel> service = new Repository<LicenseModel>();
        public string Msg { get; set; }
        public FrmAuth()
        {
            InitializeComponent();
        }

        private  void btnAuth_Click(object sender, EventArgs e)
        {

        }

        private void FrmAuth_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnHelp_Click(object sender, EventArgs e)
        {
            var url = "https://api.whatsapp.com/send?phone=447999197856";
            Process.Start(url);
        }

       
    }
}
