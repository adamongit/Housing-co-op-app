using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using BusinessObjects;

namespace DataAccessLayer
{
    public class MeetingDataContext : DataContext
    {
        public MeetingDataContext(string connectionString)
            : base(connectionString)
        {

        }

        public Table<Meeting> Meetings;
        public Table<Subgroup> Subgroups;

    }
}
