using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_Entity_Gyak.Model;

namespace WCF_Entity_Gyak.DAL
{
    public class GrainFunctions
    {
        public Grain GetGrainById(int grainId)
        {
            Grain grain;
            using (DataBaseContext db = new DataBaseContext())
            {
                grain = db.Grains.FirstOrDefault(p => p.Id == grainId);
            }
            return grain;
        }

        public List<Grain> GetGrains()
        {
            List<Grain> grains;
            using (DataBaseContext db = new DataBaseContext())
            {
                grains = db.Grains.ToList();
            }
            return grains;
        }

        public bool AddGraind(string name, double price)
        {
            if (name == "" || price == 0)
            {
                return false;
            }

            Grain grain = new Grain
            {
                Name = name,
                Price = price
            };
            return true;
        }
    }
}