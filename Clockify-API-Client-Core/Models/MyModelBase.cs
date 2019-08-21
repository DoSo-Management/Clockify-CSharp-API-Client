using Clockify_API_Client_Core.PersistentObjects;
using DevExpress.Xpo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clockify_API_Client_Core.Models
{
    public class MyModelBase
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        public virtual MyBase MapToPersistentObject(MyBase obj) => throw new NotImplementedException();

        public virtual MyBase CreatePersistentObject(Session session) => throw new NotImplementedException();

    }
}
