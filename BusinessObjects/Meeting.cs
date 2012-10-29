using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
    /// <summary>
    /// Class representing the Meeting db object.
    /// </summary>
    public class Meeting
    {
        /// <summary>
        /// Gets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets the sub group id.
        /// </summary>
        /// <value>
        /// The sub group id.
        /// </value>
        public int SubGroupId { get; private set; }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        public String Location { get; set; }

        /// <summary>
        /// Gets the date time from.
        /// </summary>
        /// <value>
        /// The date time from.
        /// </value>
        public DateTime DateTimeFrom { get; set; }

        /// <summary>
        /// Gets the date time to.
        /// </summary>
        /// <value>
        /// The date time to.
        /// </value>
        public DateTime DateTimeTo { get; set; }



    }
}
