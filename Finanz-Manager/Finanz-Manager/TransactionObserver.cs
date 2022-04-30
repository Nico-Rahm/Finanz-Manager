using System;
using System.Collections.Generic;
using System.Text;

namespace Finanz_Manager
{
    class TransactionObserver
    {
        private List<Account> accounts = new List<Account>();
        private MainForm mainForm;

        public TransactionObserver(MainForm pMainForm)
        {
            this.mainForm = pMainForm;
            this.initalize();
        }

        public void initalize()
        {
            this.readAccounts();
            foreach(Account account in accounts)
            {
                account.readTransactions();
            }
        }

        public List<Account> getObservedAccounts()
        {
            return this.accounts;
        }

        public void readAccounts()
        {
            accounts = DBconnector.getAccounts();
        }

        public void refreshAccount(int pAccountId)
        {
            foreach(Account account in accounts)
            {
                if(account.getAccountID() == pAccountId)
                {
                    account.readTransactions();
                    break;
                }
            }
            
        }

    }
}
