using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;

namespace Clockify_API_Client_Core.PersistentObjects
{
    public class ClockifyUser : MyBase
    {
        public ClockifyUser(Session session) : base(session) { }

        public string Email { get; set; }

        public string Name { get; set; }

        public string ActiveWorkspace { get; set; }

        public string DefaultWorkspace { get; set; }

        public string Status { get; set; }
    }
}
