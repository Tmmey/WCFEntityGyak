using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using WCF_Entity_Gyak.Model;

namespace WCF_Entity_Gyak.DAL
{
    public class InsuranceFunctions
    {
        public bool AddInsurance(int contractId,string name)
        {
            //TODO: damage type
            if (name == "")
                return false;
            Insurance insurance = new Insurance()
            {
                Name = name
            };

            using (var db = new DataBaseContext())
            {
                db.Insurances.Attach(insurance);
                db.Insurances.Add(insurance);
                db.SaveChanges();
            }
            return true;
        }

        public Insurance GetInsuranceById(int insuranceId)
        {
            Insurance insurance;
            using (DataBaseContext db = new DataBaseContext())
            {
                insurance = db.Insurances.FirstOrDefault(p => p.Id == insuranceId);
            }
            return insurance;
        }

        public List<Insurance> GetInsurances()
        {
            List<Insurance> insurances;
            using (DataBaseContext db = new DataBaseContext())
            {
                insurances = db.Insurances.ToList();
            }
            return insurances;
        }

    }
}