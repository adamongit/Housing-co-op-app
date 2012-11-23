using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace BusinessObjects
{
    /// <summary>
    /// Class representing the Meeting db object.
    /// </summary>
    [Table(Name = "Meeting")]
    public class Meeting
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
        /// Gets the sub group id.
        /// </summary>
        /// <value>
        /// The sub group id.
        /// </value>
        [Column]
        public int SubGroupId { get; set; }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        [Column(Name="Location")]
        public String Location_ { get; set; }

        /// <summary>
        /// Gets the date time from.
        /// </summary>
        /// <value>
        /// The date time from.
        /// </value>
        [Column]
        public DateTime DateTimeFrom { get; set; }

        /// <summary>
        /// Gets the date time to.
        /// </summary>
        /// <value>
        /// The date time to.
        /// </value>
        [Column]
        public DateTime DateTimeTo { get; set; }
    }
}
