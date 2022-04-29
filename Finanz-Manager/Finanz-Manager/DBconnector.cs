using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Finanz_Manager
{
    static class DBconnector
    {
        private static String loadConnectionString(string id = "Default")
        {
            return "Data Source =.\\Data.db; Version = 3\" providerName=\"System.Data.SqlClient";
        }

        public static void addTransaction(Transaction pTransaction)
        {
            
            using (IDbConnection cnn = new SQLiteConnection("Data Source =.\\Data.db; Version = 3"))
            {

            }
        } 

        public static void addAccount(Account pAccount)
        {
            using (IDbConnection cnn = new SQLiteConnection("Data Source =.\\Data.db; Version = 3"))
            {
                //if(pAccount.getDescription() != "")
                //{
                    cnn.Execute("INSERT INTO Accounts (accountName, description) values ('" + pAccount.getAccountName() + "', '" + pAccount.getDescription() + "')");
                //}
               // else
                //{
                //    cnn.Execute("INSERT INTO Accounts (accountName) values ('giroKonto')", pAccount);
                //}
                
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

        public int getAccountIdFromName(String pAccountName)
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
