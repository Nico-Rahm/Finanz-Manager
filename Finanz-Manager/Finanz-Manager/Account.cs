using System;
using System.Collections.Generic;
using System.Text;

namespace Finanz_Manager
{
    public class Account : Dataset
    {
        private int accountID;
        private String accountName;
        private String description;
        private String balance;
        private List<Transaction> accountTransactions = new List<Transaction>();

        public void setAccountID(int pAccountID)
        {
            this.accountID = pAccountID;
        }

        public int getAccountID()
        {
            return this.accountID;
        }

        public void setAccountName(String pAccountName)
        {
            this.accountName = pAccountName;
        }

        public String getAccountName()
        {
            return this.accountName;
        }

        public void setDescription(String pDescription)
        {
            this.description = pDescription;
        }

        public String getDescription()
        {
            return this.description;
        }

        public List<Transaction> getTransactions()
        {
            return this.accountTransactions;
        }

        public void readTransactions()
        {
            this.accountTransactions = DBconnector.getTransactions(this.accountName);
        }

        public int getBalance()
        {
            int balance = 0;
            foreach(Transaction transaction in this.accountTransactions)
            {
                balance = balance + transaction.getTransactionAmount();
            }
            return balance;
        }

        public Account()
        {
            this.type = "Account";
        }

        public Account(String pAccountName, String pAccountDescription)
        {
            this.accountName = pAccountName;
            this.description = pAccountDescription;
        }
    }
}
