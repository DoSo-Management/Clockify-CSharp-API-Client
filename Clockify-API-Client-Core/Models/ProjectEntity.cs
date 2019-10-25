using System;
using System.Collections.Generic;
using System.Text;
using Clockify_API_Client_Core.PersistentObjects;
using DevExpress.Xpo;

namespace Clockify_API_Client_Core.Models
{
    public class ProjectEntity : MyModelBase
    {
        public string name { get; set; }
        public string clientId { get; set; }
        public string workspaceId { get; set; }
        public bool billable { get; set; }
        public string color { get; set; }
        public bool archived { get; set; }
        public string duration { get; set; }
        public string clientName { get; set; }

        public override MyBase CreatePersistentObject(Session session) => new ClockifyProject(session) { };

        public override MyBase MapToPersistentObject(MyBase obj)
        {
            if (obj is ClockifyProject item)
            {
                item.Id = Id;
                item.name = name;
                item.clientId = clientId;
                item.workspaceId = workspaceId;
                item.billable = billable;
                item.color = color;
                item.archived = archived;
                item.duration = duration;
                item.clientName = clientName;

                //time.billable = billable;
                //        time.description = description;
                //        time.duration = timeInterval.duration;
                //        time.end = timeInterval.end;
                //        time.isLocked = isLocked;
                //        time.projectId = projectId;
                //        time.start = timeInterval.start;
                //        time.tagIds = tagIds;
                //        time.taskId = taskId;
                //        time.userId = userId;
                //        time.workspaceId = workspaceId;
            }

            return obj;
        }
    }
}
