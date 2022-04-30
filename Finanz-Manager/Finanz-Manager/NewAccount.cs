using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Finanz_Manager
{
    public partial class NewAccount : Form
    {
        private MainForm mainForm;
        public NewAccount(MainForm pMainForm)
        {
            InitializeComponent();
            this.mainForm = pMainForm;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Account newAccount = new Account(this.textBoxAccountName.Text, this.textBoxDescription.Text);
            DBconnector.addAccount(newAccount);

            this.Close();
        }
    }
}
