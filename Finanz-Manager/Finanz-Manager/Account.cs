using System;
using System.Collections.Generic;
using System.Text;

namespace Finanz_Manager
{
    class Account : Dataset
    {
        private int accountID;
        private String accountName;

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

        public Account()
        {
            this.type = "Account";
        }
    }
}
