using System.ComponentModel.DataAnnotations;

namespace _3DPropertiesAPI.Models
{
    public class Picture : Media
    {
        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for title is {1}")]
        public string Category { get; set; }

    }
}
