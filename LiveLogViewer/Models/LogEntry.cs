using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveLogViewer.Models
{
    /// <summary>
    /// Represents the model of the log entry
    /// </summary>
    public class LogEntry
    {
        /// <summary>
        /// Identifier that separates one trace from another.
        /// </summary>
        public int Activity { get; set; }

        /// <summary>
        /// The date/time of the entry.
        /// </summary>
        /// <remarks>
        /// This date/time is used to retrieve more entries based on the last update time.
        /// </remarks>
        public DateTime EntryDateTime { get; set; }

        /// <summary>
        /// The actual message of the entry
        /// </summary>
        public string Message { get; set; }

    }
}