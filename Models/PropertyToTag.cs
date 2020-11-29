using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3DPropertiesAPI.Models
{
    public class PropertyToTag
    {
        [Range(0, 1000000000)]
        public int PropertyId { get; set; }

        [ForeignKey("PropertyId")]
        public Property Property { get; set; }

        [Range(0, 1000000000)]
        public int PropertyTagId { get; set; }

        [ForeignKey("PropertyTagId")]
        public PropertyTag PropertyTag { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
