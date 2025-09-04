using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enums
{
    public enum TicketCategory
    {
        [Display(Name = "VIP")]
        VIP = 1,
        [Display(Name = "CAT1 Left-Lower")]
        CAT1lEFTlOWER = 2,
        [Display(Name = "CAT2")]
        CAT2 = 3,
        [Display(Name = "CAT3 Left-Upper")]
        CAT3LEFTUPPER = 4,
        [Display(Name = "CAT3 Left-Lower")]
        CAT3LEFTLOWER = 5,

    }
}
