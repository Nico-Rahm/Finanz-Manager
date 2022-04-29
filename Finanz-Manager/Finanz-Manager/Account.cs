using System;
using System.Collections.Generic;
using System.Text;

namespace Finanz_Manager
{
    class Account : Dataset
    {
        private int accountID;
        private String accountName;
        private String description;

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
