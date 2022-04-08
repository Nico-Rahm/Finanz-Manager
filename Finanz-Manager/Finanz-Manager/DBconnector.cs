using System;
using System.Collections.Generic;
using System.Text;

namespace Finanz_Manager
{
    static class DBconnector
    {

        public static void openConnection()
        {

        }

        public static void closeConnection()
        {

        }

        public static void writeDataset(Dataset pDataset)
        {
            openConnection();
            if(pDataset.getDatasetType() == "Transaction")
            {

            }
            else if(pDataset.getDatasetType() == "Account")
            {

            }
            else
            {

            }
            closeConnection();
        } 

        public static Dataset readDataset()
        {
            return null;
        }

    }
}
