using Clockify_API_Client_Core.Extensions;
using Clockify_API_Client_Core.UserClasses;
using CSharpFunctionalExtensions;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Clockify_API_Client_Core.TesterConsole
{
    public class ClockifyAPIClient : IDisposable
    {
        public ClockifyAPIClient(string x_Api_Key)
        {
            if (x_Api_Key == null) throw new ArgumentNullException(nameof(x_Api_Key));

            Client.BaseAddress = new Uri("https://api.clockify.me/api/");
            Client.DefaultRequestHeaders.Add("X-Api-Key", x_Api_Key);
        }

        readonly HttpClient Client = new HttpClient();

        public async Task<Response<T>> GetDataFromAPI<T>(string address)
        {
            try
            {
                var task = await Client.GetAsync(address);
                var jsonString = await task.Content.ReadAsStringAsync();

                try { return new Response<T>(jsonString, Result.Ok(JsonConvert.DeserializeObject<T>(jsonString, Converter.Settings)), Maybe<Exception>.None); }
                catch (Exception generalException) { return new Response<T>(jsonString, Result.Fail<T>(generalException.Message + "\r\n".Times(2)), generalException); }
            }
            catch (Exception ex) { return new Response<T>(Maybe<string>.None, Result.Fail<T>(ex.Message + "\r\n".Times(2)), ex); }
        }

        public void Dispose() => Client.Dispose();

        public class Response<T>
        {
            public Response(Maybe<string> jsonResponse, Result<T> deserializedResponseResult, Maybe<Exception> exception)
            {
                JsonResponse = jsonResponse;
                DeserializedResponseResult = deserializedResponseResult;
                Exception = exception;
            }
            public bool JsonResponseWasSuccessful => JsonResponse.HasValue;
            public bool IsSuccess => DeserializedResponseResult.IsSuccess;
            public Maybe<string> JsonResponse { get; }
            public Maybe<Exception> Exception { get; }
            public Result<T> DeserializedResponseResult { get; }
        }
    }
}
