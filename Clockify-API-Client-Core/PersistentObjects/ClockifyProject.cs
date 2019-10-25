using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;

namespace Clockify_API_Client_Core.PersistentObjects
{
    public class ClockifyProject : MyBase
    {
        public ClockifyProject(Session session) : base(session) { }

        public string name { get; set; }
        public string clientId { get; set; }
        public string workspaceId { get; set; }
        public bool billable { get; set; }
        public string color { get; set; }
        public bool archived { get; set; }
        public string duration { get; set; }
        public string clientName { get; set; }
    }
}
