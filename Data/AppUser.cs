using _3DPropertiesAPI.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3DPropertiesAPI.Data
{
    public class AppUser : IdentityUser
    {
        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for first name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(256, ErrorMessage = "Maximum length for middle name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "Maximum length for last name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(256, ErrorMessage = "Maximum length for display name is {1}")]
        [RegularExpression("^[A-Za-z]+$")]
        [Display(Name = "Name")]
        public string DisplayName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Range(0, 1000000000)]
        public int? ProfilePicId { get; set; }

        [ForeignKey("ProfilePicId")]
        public Picture ProfilePic { get; set; }

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "Updated At")]
        public DateTime? UpdatedAt { get; set; }

        public bool Deleted { get; set; }

        public List<Favorite> Favorites { get; set; }

        public List<Rating> Ratings { get; set; }
    }
}
