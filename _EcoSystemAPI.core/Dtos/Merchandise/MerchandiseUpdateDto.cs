using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EcoSystemAPI.core.Dtos.Merchandise
{
    public class MerchandiseUpdateDto
    {
        [Required]
        public string MerchName { get; set; }
        [Required]
        public string MerchDetails { get; set; }
        [Required]
        public string MerchLink { get; set; }
        [Required]
        public string MerchImage { get; set; }
    }
}
