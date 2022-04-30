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
        TransactionObserver observer;
        List<Account> accounts;
        public MainForm()
        {
            InitializeComponent();
            String file = ConfigurationManager.AppSettings["DatabaseFile"];
            if(file == "")
            {

            }
            observer = new TransactionObserver(this);
        }

        public void loadTransactions(String pAccount)
        {
            Calculator calc = new Calculator();
            List<Transaction> transactionList = DBconnector.getTransactions(pAccount);
            List<int> amounts = new List<int>();
            dataGridView1.Rows.Clear();
            int iRowCount = 0;
            foreach(Transaction transaction in transactionList)
            {
                amounts.Add(transaction.getTransactionAmount());
                dataGridView1.Rows.Add(1);
                dataGridView1[0, iRowCount].Value = transaction.getTransactionDateTime();
                dataGridView1[1, iRowCount].Value = transaction.getTransactionDescription();
                dataGridView1[2, iRowCount].Value = transaction.getTransactionAmount().ToString();
                iRowCount++;
            }
            dataGridView1.Rows.Add(1);
            dataGridView1[1, iRowCount].Value = "Saldo: ";
            dataGridView1[2, iRowCount].Value = calc.calculateBalance(amounts);
        }

        private void neuesKontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAccount newAccount = new NewAccount(this);
            newAccount.Visible = true;
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            NewTransaction newTransaction = new NewTransaction(this);
            newTransaction.Visible = true;
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {

        }

        private void kontenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChooseAccount chooseAccount = new ChooseAccount(this);
            chooseAccount.Visible = true;
        }

       public void refreshObserver(int pAccountId)
        {
            observer.refreshAccount(pAccountId);
        }

        public void newAccount()
        {
            observer.readAccounts();
        }


    }
}
