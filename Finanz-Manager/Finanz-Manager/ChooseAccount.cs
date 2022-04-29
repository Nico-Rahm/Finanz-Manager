using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Finanz_Manager
{
    public partial class ChooseAccount : Form
    {
        public ChooseAccount()
        {
            InitializeComponent();
        }

        private void ChooseAccount_Load(object sender, EventArgs e)
        {
            List<Account> accounts = DBconnector.getAccounts();
            foreach(Account account in accounts)
            {
                comboBoxAccount.Items.Add(account.getAccountName());
                
            }
        }
    }
}
