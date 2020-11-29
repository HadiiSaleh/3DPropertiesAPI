using _3DPropertiesAPI.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3DPropertiesAPI.Models
{
    public class Favorite
    {
        [Range(0, 1000000000)]
        public int PropertyId { get; set; }

        [ForeignKey("PropertyId")]
        public Property Property { get; set; }

        [StringLength(450, ErrorMessage = "Maximum length for customer id is {1}")]
        public string CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public AppUser Customer { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
