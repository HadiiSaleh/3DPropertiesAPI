using System;
using System.ComponentModel.DataAnnotations;
namespace _3DPropertiesAPI.Dtos
{
    public class VideoDto : MediaDto
    {
        [Required]
        public double Duration { get; set; }

        [Range(0, 1000000000)]
        public int? PictureId { get; set; }
    }
}
