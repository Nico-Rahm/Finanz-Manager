using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Finanz_Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            String file = ConfigurationManager.AppSettings["DatabaseFile"];
            if(file == "")
            {

            }
        }

        private void neuesKontoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            NewTransaction newTransaction = new NewTransaction();
            newTransaction.Visible = true;
        }
    }
}
