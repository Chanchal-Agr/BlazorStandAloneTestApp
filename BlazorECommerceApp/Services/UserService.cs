using BlazorECommerceApp.DTOs;
using BlazorECommerceApp.Interfaces;
using System.Net.Http.Json;
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
                var apiRes = await httpClient.GetFromJsonAsync<IEnumerable<UserDto>>("User/GetAllProfiles");
                
                return apiRes.ToList();
            }
            catch (Exception x)
            {
                throw x ;
            }

        }
    }
}
