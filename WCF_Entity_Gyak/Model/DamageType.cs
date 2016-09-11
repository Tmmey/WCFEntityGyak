using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WCF_Entity_Gyak.Model
{
    public class DamageType
    {
        public int Id { get; set; }
        public string  DamageName { get; set; }
        public double Value { get; set; }      
    }
}