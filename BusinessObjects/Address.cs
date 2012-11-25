using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace BusinessObjects
{
    /// <summary>
    /// Class representing the Address db object.
    /// </summary>
    [Table(Name = "Address")]
    public class Address
    {
        /// <summary>
        /// Gets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id", AutoSync = AutoSync.OnInsert,
            DbType = "INT NOT NULL IDENTITY")]
        public int Id { get; set; }


    }
}
