using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Finanz_Manager
{
    public partial class NewTransaction : Form
    {
        MainForm mainForm;
        public NewTransaction(MainForm pMainForm)
        {
            InitializeComponent();
            List<Account> accounts = DBconnector.getAccounts();
            foreach (Account account in accounts)
            {
                comboBoxAccount.Items.Add(account.getAccountName());

            }
            mainForm = pMainForm;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool tErrorOccured = false;

            Transaction transaction = new Transaction();

            int accountId = 0;

            accountId = DBconnector.getAccountIdFromName(this.comboBoxAccount.Text);
            transaction.setAccountId(accountId);




            transaction.setTransactionDateTime(this.dateTimePicker1.Value.ToString()) ;

            String[] amountSeperated = this.textBoxAmount.Text.Split(",");
            int tAmountEuro;
            int tAmountCent;

            bool tAmountEuroIsParsable = Int32.TryParse(amountSeperated[0], out tAmountEuro);
            bool tAmountCentIsParsable = Int32.TryParse(amountSeperated[1], out tAmountCent);


            if(tAmountEuroIsParsable && tAmountCentIsParsable)
            {
                int tAmount = (tAmountEuro * 100) + tAmountCent;
                if (radioButtonSpending.Checked)
                {
                    tAmount = 0 - tAmount;
                }
                transaction.setTransactionAmount(tAmount);
            }
            else
            {
                tErrorOccured = true;
            }

            transaction.setTransactionDescription(this.textBoxDescription.Text);

            if (tErrorOccured)
            {
                MessageBox.Show("Bitte überprüfen Sie Ihre Eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBconnector.addTransaction(transaction);
                mainForm.refreshObserver(accountId);
                this.Close();
            }
        }
    }
}
