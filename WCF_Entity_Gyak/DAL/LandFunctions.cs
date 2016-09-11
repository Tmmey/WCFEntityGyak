using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using WCF_Entity_Gyak.Model;

namespace WCF_Entity_Gyak.DAL
{
    public class LandFunctions
    {
        public static Land GetLandById(int landId)
        {
            Land land;
            using (DataBaseContext db = new DataBaseContext())
            {
                land = db.Lands.FirstOrDefault(p => p.Id == landId);
            }

            return land;
        }

        public List<Land> GetLands()
        {
            List<Land> lands;

            using (DataBaseContext db = new DataBaseContext())
            {
                lands = db.Lands.ToList();
            }

            return lands;
        }

        public bool AddLand(double size, double pricePerSquareMeter, double locationPriceModifier, string location, string ownerName,
            string bureauNumber, Enum grainType, int contractId)
        {
            Land land = new Land
            {
                Size = size,
                PricePerSquareMeters = pricePerSquareMeter,
                LocationPriceModifier = locationPriceModifier,
                Location = location,
                OwnerName = ownerName,
                BureauNumber = bureauNumber,
            };
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Lands.Attach(land);
                db.Lands.Add(land);
                db.SaveChanges();
            }
            return true;
        }
    }
}