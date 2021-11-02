using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Token { get; set; }
        [StringLength(maximumLength: 20)]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [StringLength(maximumLength: 20)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
