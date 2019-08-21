using Clockify_API_Client_Core.UserClasses;
using System.Threading.Tasks;

namespace Clockify_API_Client_Core.TesterConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new ClockifyAPIClient("XEBvLLB5hxt3UkE7"))
            {
                var result = await client.GetDataFromAPI<User[]>("v1/workspace/5c403043b079871b7750d4c8/users");
            }
        }
    }
}
