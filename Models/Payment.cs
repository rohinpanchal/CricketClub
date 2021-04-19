using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CricketClub.Models
{
    public class Payment
    {
        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }



        [Display(Name = "Payment")]
        public string payments { get; set; }


        [Display(Name = "Payment Date")]
        public string PaymentDate { get; set; }

    }
}
