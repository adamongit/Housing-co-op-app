using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using System.Data.Linq.Mapping;

namespace BusinessObjects 
{
    [Table(Name = "SubGroup")]
    public class Subgroup
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        [Column(IsPrimaryKey=true)]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Column]
        public String Name { get; set; }

       
    }
}
