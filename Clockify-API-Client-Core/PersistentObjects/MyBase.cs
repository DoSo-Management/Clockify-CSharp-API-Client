using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clockify_API_Client_Core.PersistentObjects
{
    [NonPersistent]
    public class MyBase : XPLiteObject
    {
        public MyBase(Session session) : base(session) { }

        [Key(true)]
        public Guid Oid { get; set; }
        [Indexed]
        public string Id { get; set; }
    }
}
