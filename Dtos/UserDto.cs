using _3DPropertiesAPI.Models;
using System;
using System.Collections.Generic;

namespace _3DPropertiesAPI.Dtos
{
    public class UserDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string role { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public DateTime Birthday { get; set; }
        public int? ProfilePicId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Deleted { get; set; }
        public List<Favorite> Favorites { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
