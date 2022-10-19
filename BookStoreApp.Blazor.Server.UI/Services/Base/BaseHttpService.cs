using Blazored.LocalStorage;
using System.Net.Http.Headers;

namespace BookStoreApp.Blazor.Server.UI.Services.Base
{
    public class BaseHttpService
    {
        private readonly ILocalStorageService localStorage;
        private readonly IClient client;

        public BaseHttpService(IClient client, ILocalStorageService localStorage)
        {
            this.localStorage = localStorage;
            this.client = client;
        }

        protected Response<Guid> ConvertApiExceptions<Guid>(ApiException apiException)
        {
            if(apiException.StatusCode == 400)
            {
                return new Response<Guid>() 
                { 
                    Message = "Validation errors have occured.", 
                    ValidationErrors = apiException.Response, 
                    Success = false 
                };
            }

            if (apiException.StatusCode == 404)
            {
                return new Response<Guid>()
                {
                    Message = "The required item could not be found.",
                    ValidationErrors = apiException.Response,
                    Success = false
                };
            }

            if(apiException.StatusCode >= 200 && apiException.StatusCode <= 299) 
            {
                return new Response<Guid>()
                {
                    Message = "Operation Reported Success.",
                    Success = true
                };
            }

            return new Response<Guid>()
            {
                Message = "Something went wrong, please try again.",
                Success = false
            };
        }

        protected async Task GetBearerToken() 
        {
            var token = await localStorage.GetItemAsync<string>("accessToken");

            if(token != null)
            {
                client.HttpCliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            }
        }
    }
}
