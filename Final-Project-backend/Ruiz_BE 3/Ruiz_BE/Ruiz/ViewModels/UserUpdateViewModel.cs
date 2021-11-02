using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.ViewModels
{
    public class UserUpdateViewModel
    {

        [StringLength(maximumLength: 50)]
        public string FullName { get; set; }
        [Required]
        [StringLength(maximumLength: 25)]
        public string UserName { get; set; }
        [StringLength(maximumLength: 250)]
        public string Address1 { get; set; }
        [StringLength(maximumLength: 250)]
        public string Address2 { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(maximumLength: 20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(maximumLength: 20)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [StringLength(maximumLength: 20)]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
    }
}
