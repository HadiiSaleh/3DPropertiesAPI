using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3DPropertiesAPI.Models
{
    public class Media
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for name is {1}")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Maximum length for extension is {1}")]
        public string Extension { get; set; }

        [Required]
        [StringLength(int.MaxValue, ErrorMessage = "Maximum length for path is {1}")]
        public string Path { get; set; }

        [Range(0, 1000000000)]
        public int Size { get; set; }

        [Range(0, 1000000000)]
        public int? PropertyId { get; set; }

        [ForeignKey("PropertyId")]
        public Property Property { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
