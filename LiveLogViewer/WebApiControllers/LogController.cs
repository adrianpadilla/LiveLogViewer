using System.Web.Http.OData;
using LiveLogViewer.Models;
using System.Collections.Generic;
using System;
using System.Linq;


namespace LiveLogViewer.Controllers
{
    public class LogController : EntitySetController<LogEntry, int>
    {
        public override System.Linq.IQueryable<LogEntry> Get()
        {
            return MockLogGenerator.GetStaticExampleLogs().AsQueryable<LogEntry>();
        }
    }
}
