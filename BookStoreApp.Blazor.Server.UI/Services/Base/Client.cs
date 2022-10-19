namespace BookStoreApp.Blazor.Server.UI.Services.Base
{
    public partial class Client : IClient
    {
        public HttpClient HttpCliente {
            get
            {
                return _httpClient;
            }
        }
    }
}
