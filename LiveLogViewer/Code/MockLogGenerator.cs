using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LiveLogViewer.Models;

namespace LiveLogViewer
{
    /// <summary>
    /// Used to generate mock log data.
    /// </summary>
    public static class MockLogGenerator
    {
        public static List<LogEntry> GetStaticExampleLogs()
        {
            List<LogEntry> list = new List<LogEntry>();

            for (int i = 0; i < 50; i++)
            {
                list.Add(new LogEntry()
                {
                     Activity = 10000,
                     EntryDateTime = DateTime.Now.AddHours(-1),
                     Message = string.Format("Mock Message #{0:d}: {1}", i, Guid.NewGuid().ToString())
                });
            }

            return list;
        }
    }
}