﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using BusinessObjects;

namespace DataAccessLayer
{
    public class SubGroupDataContext : DataContext
    {
        public SubGroupDataContext(string connectionString)
            : base(connectionString)
        {
            
        }

        public Table<Subgroup> Subgroups;

    }
}
