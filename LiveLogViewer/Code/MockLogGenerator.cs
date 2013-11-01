using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LiveLogViewer.Models;
using System.Threading;
using System.Threading.Tasks;

namespace LiveLogViewer
{
    /// <summary>
    /// Used to generate mock log data.
    /// </summary>
    public static class MockLogGenerator
    {
        static List<LogEntry> List = new List<LogEntry>();

        static Random Random = new Random();

        static MockLogGenerator()
        {
                List.Add(new LogEntry()
                {
                    Activity = 10000,
                    EntryDateTime = DateTime.Now.AddSeconds(-3),
                    Message = string.Format("Mock Message: {0}", Guid.NewGuid().ToString())
                });

                Task.Factory.StartNew(() =>
                {
                    GenerateLogLoop();
                });

        }

        private static void GenerateLogLoop()
        {
            int next = 0;
            while (true)
            {
                List.Add(new LogEntry()
                {
                    Activity = 10000,
                    EntryDateTime = DateTime.Now,
                    Message = string.Format("Mock Message: {0}", Guid.NewGuid().ToString())
                });

                //Removes older entries
                List.RemoveAll(l => l.EntryDateTime < DateTime.Now.AddSeconds(-10));

                next = Random.Next(1000);

                Thread.Sleep(next);
            }
        }
        
        public static List<LogEntry> GetStaticExampleLogs()
        {
            return List;
        }
    }
}