using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WCF_Entity_Gyak.Model
{
    public class Insurance
    {
        public int Id { get; set; }
        public Dictionary<string,double> DamageType { get; set; }
        [Required]
        public Contract Contract { get; set; }

    }
}