﻿using System.ComponentModel.DataAnnotations;

namespace Services.Identity.Dtos
{
    public class SignUpDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string City { get; set; }
    }
}
