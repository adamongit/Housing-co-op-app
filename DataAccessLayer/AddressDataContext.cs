﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using BusinessObjects;

namespace DataAccessLayer
{
    public class AddressDataContext : DataContext
    {

        public AddressDataContext(string connectionString)
            : base(connectionString)
        {
            
        }

        public Table<Address> Addresses;
    }
}
