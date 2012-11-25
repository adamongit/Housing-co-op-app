using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace BusinessObjects
{
    /// <summary>
    /// Class representing the ContractorAddress db object.
    /// </summary>
    [Table(Name = "ContractorAddress")]
    public class ContractorAddress
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

        /// <summary>
        /// Gets or sets the contractor id.
        /// </summary>
        /// <value>
        /// The contractor id.
        /// </value>
        [Column]
        public int ContractorId { get; set; }

        /// <summary>
        /// Gets or sets the address id.
        /// </summary>
        /// <value>
        /// The address id.
        /// </value>
        [Column]
        public int AddressId { get; set; }


    }
}
