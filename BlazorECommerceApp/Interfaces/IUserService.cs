using BlazorECommerceApp.DTOs;

namespace BlazorECommerceApp.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDto>?> GetAllProfiles();
    }
}
