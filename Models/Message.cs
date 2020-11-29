using _3DPropertiesAPI.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3DPropertiesAPI.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(450, ErrorMessage = "Maximum length is {1}")]
        public string ReceiverId { get; set; }

        [ForeignKey("ReceiverId")]
        public AppUser Receiver { get; set; }

        [Required]
        [Range(0, 1000000000)]
        public int MessageDetailsId { get; set; }

        [ForeignKey("MessageDetailsId")]
        public MessageDetails MessageDetails { get; set; }

        public bool Read { get; set; } = false;

        public bool Deleted { get; set; } = false;
    }
}
