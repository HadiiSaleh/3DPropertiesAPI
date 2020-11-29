using System.ComponentModel.DataAnnotations;

namespace _3DPropertiesAPI.Dtos
{
    public class PictureDto : MediaDto
    {
        [Range(0, 1000000000)]
        public int? VideoId { get; set; }

        [StringLength(256, ErrorMessage = "Maximum length for title is {1}")]
        public string Category { get; set; }
    }
}
