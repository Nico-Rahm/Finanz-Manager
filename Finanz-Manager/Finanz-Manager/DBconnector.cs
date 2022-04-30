using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Finanz_Manager
{
    public static class DBconnector
    {

        public static void addTransaction(Transaction pTransaction)
        {
            using (IDbConnection cnn = new SQLiteConnection("Data Source =.\\Data.db; Version = 3"))
            {
                cnn.Execute("INSERT INTO Transactions (accountId, amountEuroCents, transactionDateTime, description) values (" +
                    pTransaction.getAccountId() + ", " + pTransaction.getTransactionAmount() + ", '" + 
                    pTransaction.getTransactionDateTime() + "', '" + pTransaction.getTransactionDescription() + "')");
            }
        } 

        public static void addAccount(Account pAccount)
        {
            using (IDbConnection cnn = new SQLiteConnection("Data Source =.\\Data.db; Version = 3"))
            {               
                cnn.Execute("INSERT INTO Accounts (accountName, description) values ('" + pAccount.getAccountName() + "', '" + pAccount.getDescription() + "')");

            }
        }

        public static List<Account> getAccounts()
        {
            using (IDbConnection cnn = new SQLiteConnection("Data Source =.\\Data.db; Version = 3"))
            {
                var output = cnn.Query<Account>("SELECT * FROM Accounts", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Transaction> getTransactions(String pAccountName)
        {
            using (IDbConnection cnn = new SQLiteConnection("Data Source =.\\Data.db; Version = 3"))
            {
                List<String> account = cnn.Query<String>("SELECT id FROM Accounts WHERE accountName = '" + pAccountName + "'").ToList();
                int accountId = Int32.Parse(account[0]);
                var output = cnn.Query<Transaction>("SELECT * FROM Transactions WHERE accountId = " + accountId, new DynamicParameters());
                return output.ToList();
            }
        }

        public static int getAccountIdFromName(String pAccountName)
        {
            using (IDbConnection cnn = new SQLiteConnection("Data Source =.\\Data.db; Version = 3"))
            {
                List<String> account = cnn.Query<String>("SELECT id FROM Accounts WHERE accountName = '" + pAccountName + "'").ToList();
                int accountId = Int32.Parse(account[0]);
                return accountId;
            }
        }

    }
}
