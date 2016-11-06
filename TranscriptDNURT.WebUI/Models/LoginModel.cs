﻿using System.ComponentModel.DataAnnotations;

namespace TranscriptDNURT.WebUI.Models
{
    public class LoginModel
    {
        [Required]
        public string login { get; set; } /* логин пользователя */

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; } /* пароль пользователя */
    }
}