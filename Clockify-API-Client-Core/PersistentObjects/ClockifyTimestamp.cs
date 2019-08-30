using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;

namespace Clockify_API_Client_Core.PersistentObjects
{
    public class ClockifyTime : MyBase
    {
        public ClockifyTime(Session session) : base(session) { }


        public DateTime start { get; set; }
        public DateTime? end { get; set; }
        public string duration { get; set; }
        [Size(-1)]
        public string description { get; set; }
        public List<object> tagIds { get; set; }
        public string userId { get; set; }
        public bool billable { get; set; }
        public object taskId { get; set; }
        public string projectId { get; set; }
        public string workspaceId { get; set; }
        public bool isLocked { get; set; }
    }
}
