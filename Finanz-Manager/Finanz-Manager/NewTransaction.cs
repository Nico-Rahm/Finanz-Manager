﻿using System;
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
        public NewTransaction()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool errorOccured = false;

            Transaction transaction = new Transaction();
            transaction.setTableName(this.comboBoxAccount.Text);
            transaction.setTransactionDateTime(this.dateTimePicker1.Value);

            int tAmount;
            bool amountIsParsable = Int32.TryParse(this.textBoxAmount.Text, out tAmount);
            if(amountIsParsable)
            {
                if (radioButtonSpending.Checked)
                {
                    tAmount = 0 - tAmount;
                }
                transaction.setTransactionAmount(tAmount);
            }
            else
            {
                errorOccured = true;
            }

            transaction.setTransactionDescription(this.textBoxDescription.Text);

            if (errorOccured)
            {
                MessageBox.Show("Bitte überprüfen Sie Ihre Eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBconnector.writeDataset(transaction);
            }
        }
    }
}