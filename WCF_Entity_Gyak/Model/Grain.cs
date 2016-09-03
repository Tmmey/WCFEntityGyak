using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace WCF_Entity_Gyak.Model
{
    public class Grain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}