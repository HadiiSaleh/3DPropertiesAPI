﻿using System.ComponentModel.DataAnnotations;

namespace _3DPropertiesAPI.Dtos
{
    public class LoginDto
    {
        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for username is {1}")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(256, ErrorMessage = "Maximum length for password is {1}")]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9_]).*$")]
        public string Password { get; set; }
    }
}
