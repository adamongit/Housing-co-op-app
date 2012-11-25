using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace BusinessObjects
{
    /// <summary>
    /// Class representing the Contractor db object.
    /// </summary>
    [Table(Name = "Contractor")]
    public class Contractor
    {
        /// <summary>
        /// Gets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        [Column(IsPrimaryKey=true, IsDbGenerated=true, Name="id", AutoSync=AutoSync.OnInsert,
            DbType="INT NOT NULL IDENTITY")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the contractor.
        /// </summary>
        /// <value>
        /// The name of the contractor.
        /// </value>
        [Column]
        public String Name { get; set; }
    }
    
}
