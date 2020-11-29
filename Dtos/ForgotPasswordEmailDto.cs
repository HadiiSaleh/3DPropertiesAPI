using System.ComponentModel.DataAnnotations;

namespace _3DPropertiesAPI.Dtos
{
    public class ForgotPasswordEmailDto
    {
        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for email address is {1}")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
    }
}
