using BlazorECommerceApp.DTOs;
using BlazorECommerceApp.Interfaces;
using System.Text.Json;

namespace BlazorECommerceApp.Services
{
    public class UserService:IUserService
    {
        private readonly HttpClient httpClient;
        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<UserDto>?> GetAllProfiles()
        {
            try
            {
                var apiRes = await httpClient.GetStreamAsync("User/GetAllProfiles");
                var profiles = await JsonSerializer.DeserializeAsync<List<UserDto>>(apiRes, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return profiles;
            }
            catch (Exception x)
            {
                throw x ;
            }

        }
    }
}
