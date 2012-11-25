using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using BusinessObjects;

namespace DataAccessLayer
{
    public class ContractorDataContext : DataContext
    {
        public ContractorDataContext(string connectionString)
            : base(connectionString)
        {
            
        }

        public Table<Contractor> Contractors;
    }
}
