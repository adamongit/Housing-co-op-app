using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace BusinessObjects
{
    /// <summary>
    /// Represents a MemberMeeting db object
    /// </summary>
    [Table(Name = "MemberMeeting")]
    public class MemberMeeting
    {
        /// <summary>
        /// Gets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public int Id { get; private set; }
        /// <summary>
        /// Gets the meeting id.
        /// </summary>
        /// <value>
        /// The meeting id.
        /// </value>
        public int MeetingId { get; private set; }
        /// <summary>
        /// Gets the member id.
        /// </summary>
        /// <value>
        /// The member id.
        /// </value>
        public int MemberId { get; private set; }

    }
}
