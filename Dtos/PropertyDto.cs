using _3DPropertiesAPI.Models;
using System;
using System.Collections.Generic;

namespace _3DPropertiesAPI.Dtos
{
    public class PropertyDto
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string? Description { get; set; }

        public int CategoryId { get; set; }

        public PropertyCategory Category { get; set; }

        public bool Deleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public List<MediaDto> Medias { get; set; }

        public List<Favorite> Favorites { get; set; }

        public List<Rating> Ratings { get; set; }
    }
}
