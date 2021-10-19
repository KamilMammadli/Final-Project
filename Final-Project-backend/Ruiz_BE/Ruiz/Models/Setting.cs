using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 30)]
        public string HeaderLogo { get; set; }
        [StringLength(maximumLength: 50)]
        public string Address { get; set; }
        [StringLength(maximumLength: 50)]
        public string Country { get; set; }
        [StringLength(maximumLength: 25)]
        public string Phone { get; set; }
        [StringLength(maximumLength: 25)]
        public string Fax { get; set; }
        [StringLength(maximumLength: 30)]
        public string Email { get; set; }
        [StringLength(maximumLength: 50)]
        public string FbIcon { get; set; }
        [StringLength(maximumLength: 50)]
        public string TwitterIcon { get; set; }
        [StringLength(maximumLength: 50)]
        public string InstagramIcon { get; set; }
        [StringLength(maximumLength: 50)]
        public string LinkedinIcon { get; set; }
        [StringLength(maximumLength: 50)]
        public string RssIcon { get; set; }
        [StringLength(maximumLength: 30)]
        public string Paymentmethods { get; set; }
        [StringLength(maximumLength: 30)]
        public string GooglePlayImg { get; set; }
        [StringLength(maximumLength: 30)]
        public string AppStoreImg { get; set; }
        [StringLength(maximumLength: 20)]
        public string Banner1 { get; set; }
        [StringLength(maximumLength: 20)]
        public string Banner2 { get; set; }
        [StringLength(maximumLength: 20)]
        public string Banner3 { get; set; }
        [StringLength(maximumLength: 20)]
        public string Banner4 { get; set; }
    }
}
