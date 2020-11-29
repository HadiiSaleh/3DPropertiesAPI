using _3DPropertiesAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3DPropertiesAPI.Models
{
    public class MessageDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(450, ErrorMessage = "Maximum length is {1}")]
        public string SenderId { get; set; }

        [ForeignKey("SenderId")]
        public AppUser Sender { get; set; }

        [StringLength(100, ErrorMessage = "Maximum length is {1}")]
        public string SenderRole { get; set; }

        [StringLength(450, ErrorMessage = "Maximum length is {1}")]
        public string SentTo { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Maximum length is {1}")]
        public string Title { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Maximum length is {1}")]
        public string Body { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public bool Deleted { get; set; } = false;

        public List<Message> Messages { get; set; }
    }
}
