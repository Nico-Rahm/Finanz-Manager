﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Finanz_Manager
{
    class Transaction : Dataset
    {
        private DateTime transactionDateTime;
        private String transactionDescription;
        private int transactionAmountEuroCents;
        private int accountId;

        public void setTransactionDateTime(DateTime pDateTime)
        {
            this.transactionDateTime = pDateTime;
        }

        public DateTime getTransactionDateTime()
        {
            return this.transactionDateTime;
        }

        public void setTransactionDescription(String pDescription)
        {
            this.transactionDescription = pDescription;
        }

        public String getTransactionDescription()
        {
            return this.transactionDescription;
        }

        public void setTransactionAmount(int pAmountEuroCents)
        {
            this.transactionAmountEuroCents = pAmountEuroCents;
        }

        public int getTransactionAmount()
        {
            return this.transactionAmountEuroCents;
        }

        public void setAccountId(int pAccountId)
        {
            this.accountId = pAccountId;
        }

        public int getAccountId()
        {
            return this.accountId;
        }

        public Transaction()
        {
            this.type = "Transaction";
        }

    }
}
