using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3DPropertiesAPI.Models
{
    public class Property
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for title is {1}")]
        public string Title { get; set; }

        [StringLength(int.MaxValue, ErrorMessage = "Maximum length for description is {1}")]
        public string? Description { get; set; }

        [Required]
        [Range(0, 1000000000)]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public PropertyCategory Category { get; set; }

        public bool Deleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public List<Media> Medias { get; set; }

        public List<Favorite> Favorites { get; set; }

        public List<Rating> Ratings { get; set; }
    }
}
