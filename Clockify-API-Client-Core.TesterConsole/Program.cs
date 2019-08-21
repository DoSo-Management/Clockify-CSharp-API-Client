using Clockify_API_Client_Core.Models;
using Clockify_API_Client_Core.PersistentObjects;
using Clockify_API_Client_Core.UserClasses;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace Clockify_API_Client_Core.TesterConsole
{
    class Program
    {
        const string workplaceId = "5c403043b079871b7750d4c8";

        static async Task Main(string[] args)
        {
            using (var client = new ClockifyAPIClient("XEBvLLB5hxt3UkE7"))
            {
                var connectionString = "Integrated Security=SSPI;Pooling=false;Data Source=localhost;Initial Catalog=ClockifyDB";
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);

                var result = await client.GetDataFromAPI<User[]>($"v1/workspace/{workplaceId}/users");

                foreach (var user in result.DeserializedResponseResult.Value)
                {
                    CreateOrUpdate<ClockifyUser>(user);
                    var times = await client.GetDataFromAPI<TimeEntity[]>($"v1/workspaces/{workplaceId}/user/{user.Id}/time-entries");
                    times.DeserializedResponseResult.Value.ToList().ForEach(x => CreateOrUpdate<ClockifyTime>(x));
                }

                Console.ReadLine();
            }
        }

        static void CreateOrUpdate<T>(MyModelBase model) where T : MyBase
        {
            using (var uow = new UnitOfWork(XpoDefault.DataLayer))
            {
                try
                {
                    var persistentObject = uow.Query<T>().FirstOrDefault(x => x.Id == model.Id) ?? model.CreatePersistentObject(uow);
                    model.MapToPersistentObject(persistentObject);
                    uow.CommitChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }
    }
}
