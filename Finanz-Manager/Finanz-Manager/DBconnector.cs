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

        public static List<Dataset> getTransaction()
        {
            return null;
        }

    }
}
