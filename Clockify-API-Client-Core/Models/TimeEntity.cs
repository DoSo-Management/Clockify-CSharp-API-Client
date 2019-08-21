using System;
using System.Collections.Generic;
using System.Text;
using Clockify_API_Client_Core.PersistentObjects;
using DevExpress.Xpo;

namespace Clockify_API_Client_Core.Models
{
    public class TimeInterval
    {
        public DateTime start { get; set; }
        public DateTime? end { get; set; }
        public string duration { get; set; }
    }

    public class TimeEntity : MyModelBase
    {
        //public string id { get; set; }
        [Size(-1)]
        public string description { get; set; }
        public List<object> tagIds { get; set; }
        public string userId { get; set; }
        public bool billable { get; set; }
        public object taskId { get; set; }
        public string projectId { get; set; }
        public TimeInterval timeInterval { get; set; }
        public string workspaceId { get; set; }
        public bool isLocked { get; set; }


        public override MyBase CreatePersistentObject(Session session) => new ClockifyTime(session) { };

        public override MyBase MapToPersistentObject(MyBase obj)
        {
            if (obj is ClockifyTime time)
            {
                time.Id = Id;
                time.billable = billable;
                time.description = description;
                time.duration = timeInterval.duration;
                time.end = timeInterval.end;
                time.isLocked = isLocked;
                time.projectId = projectId;
                time.start = timeInterval.start;
                time.tagIds = tagIds;
                time.taskId = taskId;
                time.userId = userId;
                time.workspaceId = workspaceId;
            }

            return obj;
        }
    }
}
