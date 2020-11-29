using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _3DPropertiesAPI.Models
{
    public class PropertyTag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for name is {1}")]
        public string Name { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for name is {1}")]
        public string NormalizedName { get; set; }

        [StringLength(int.MaxValue, ErrorMessage = "Maximum length for description is {1}")]
        public string? Description { get; set; }

        public bool Deleted { get; set; } = false;

        public List<PropertyToTag> PropertiesToTags { get; set; }
    }
}
