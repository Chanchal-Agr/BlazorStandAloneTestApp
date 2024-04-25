using BlazorECommerceApp.DTOs;
using BlazorECommerceApp.Entities;
using BlazorECommerceApp.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorECommerceApp.Pages
{
    public partial class ProfileList
    {

        [Inject]
        private IUserService userService { get; set; }
        public List<UserDto> profiles { get; set; } = new List<UserDto>();
        protected override async Task OnInitializedAsync()
        {
            var apiUsers = await UserService.GetAllProfiles();
            if (apiUsers != null && apiUsers.Any())
            {
                profiles = apiUsers;
            }
        }
    }
}