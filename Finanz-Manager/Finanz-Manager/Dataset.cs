using System;
using System.Collections.Generic;
using System.Text;

namespace Finanz_Manager
{
    class Dataset
    {
        protected String tableName;
        protected String type = "Dataset";

        public void setTableName(String pTableName)
        {
            this.tableName = pTableName;
        }

        public String getTableName()
        {
            return this.tableName;
        }

        public String getDatasetType()
        {
            return this.type;
        }
    }
}
