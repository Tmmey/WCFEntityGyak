using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WCF_Entity_Gyak.Model
{
    public class Contract
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ContractCreationDate { get; set; }
        //[Required]
        public User User { get; set; }
        public List<Land> Lands { get; set; }
        public List<Insurance> Insurances { get; set; }
        public Contract()
        {
            Lands = new List<Land>();
            Insurances = new List<Insurance>();
        }
    }
}