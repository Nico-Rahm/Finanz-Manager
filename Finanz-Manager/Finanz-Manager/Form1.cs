﻿using System;
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
            NewAccount newAccount = new NewAccount();
            newAccount.Visible = true;
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            NewTransaction newTransaction = new NewTransaction();
            newTransaction.Visible = true;
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {

        }

        private void kontenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChooseAccount chooseAccount = new ChooseAccount();
            chooseAccount.Visible = true;
        }
    }
}
