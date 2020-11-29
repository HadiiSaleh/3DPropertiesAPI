using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3DPropertiesAPI.Models
{
    public class Video : Media
    {
        public double Duration { get; set; }

        [Range(0, 1000000000)]
        public int? PictureId { get; set; }

        [ForeignKey("PictureId")]
        public Picture Picture { get; set; }

    }
}
