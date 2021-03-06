using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Finanz_Manager
{
    public partial class NewTransfer : Form
    {
        public NewTransfer()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Transaction transactionSourceAccount = new Transaction();
            Transaction transactionTargetAccount = new Transaction();
            bool tErrorOccured = false;

            int tAmount;
            bool tAmountIsParsable = Int32.TryParse(this.textBoxAmount.Text, out tAmount);
            if (tAmountIsParsable)
            {
                transactionSourceAccount.setTransactionAmount(0 - tAmount);
                transactionTargetAccount.setTransactionAmount(tAmount);
            }
            else
            {
                tErrorOccured = true;
            }

            transactionSourceAccount.setAccountId(Int32.Parse(comboBoxSourceAccount.Text));
            transactionSourceAccount.setTransactionDateTime(dateTimePicker1.Value.ToString());
            transactionSourceAccount.setTransactionDescription(textBoxDescription.Text);

            transactionTargetAccount.setAccountId(Int32.Parse(comboBoxTargetAccount.Text));
            transactionTargetAccount.setTransactionDateTime(dateTimePicker1.Value.ToString());
            transactionTargetAccount.setTransactionDescription(textBoxDescription.Text);

            if (tErrorOccured)
            {
                MessageBox.Show("Bitte überprüfen Sie Ihre Eingaben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBconnector.addTransaction(transactionTargetAccount);
                DBconnector.addTransaction(transactionSourceAccount);
            }
        }
    }
}
