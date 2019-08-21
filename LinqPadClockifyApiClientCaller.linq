<Query Kind="Program">
  <Reference Relative="Clockify-API-Client-Core\bin\Debug\netcoreapp2.2\Clockify-API-Client-Core.dll">&lt;MyDocuments&gt;\GitHub\Clockify-CSharp-API-Client\Clockify-API-Client-Core\bin\Debug\netcoreapp2.2\Clockify-API-Client-Core.dll</Reference>
  <Namespace>Clockify_API_Client_Core.TesterConsole</Namespace>
  <Namespace>Clockify_API_Client_Core.UserClasses</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main(string[] args)
{
	using (var client = new ClockifyAPIClient("XEBvLLB5hxt3UkE7"))
	{
		var result = client.GetDataFromAPI<User[]>("v1/workspace/5c403043b079871b7750d4c8/users");
	}
}

// Define other methods and classes here
