using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_Entity_Gyak.Model
{
    public class Land
    {
        public int Id { get; set; }
        public double Size { get; set; }
        public double PricePerSquareMeters { get; set; }
        public string Location { get; set; }
        public double LocationPriceModifier { get; set; }
        public string OwnerName { get; set; }
        public string BureauNumber { get; set; }
        public Grain Grain{ get; set; }
        public enum GrainType
        {
            Wheat,
            Rye,
            Barley,
            Corn
        }
    }
}