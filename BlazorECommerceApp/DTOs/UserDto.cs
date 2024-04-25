using BlazorECommerceApp.Enums;

namespace BlazorECommerceApp.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Mobile { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }
        public string? City { get; set; }
        public Roles Role { get; set; }
    }
}
