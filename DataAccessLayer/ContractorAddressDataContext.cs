using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using BusinessObjects;

namespace DataAccessLayer
{
    public class ContractorAddressDataContext : DataContext
    {
        public ContractorAddressDataContext(string connectionString)
            : base(connectionString)
        {
            
        }

        public Table<ContractorAddress> ContractorAddresses;
    }
}
