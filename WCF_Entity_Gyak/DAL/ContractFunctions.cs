using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_Entity_Gyak.Model;
using WCF_Entity_Gyak.DAL;

namespace WCF_Entity_Gyak.DAL
{
    public class ContractFunctions
    {
        public Contract GetContractById(int contractId)
        {
            Contract contract;
            using (DataBaseContext db = new DataBaseContext())
            {
                contract = db.Contracts.FirstOrDefault(p => p.Id == contractId);
            }
            return contract;
        }

        public List<Contract> GetContracts()
        {
            List<Contract> contracts;
            using (DataBaseContext db = new DataBaseContext())
            {
                contracts = db.Contracts.ToList();
            }
            return contracts;
        }

        public bool AddContract(int userId, DateTime? contractCreationDate, DateTime? startDate)
        {
            if (contractCreationDate==null && startDate==null)
            {
                return false;
            }
            Contract contract = new Contract
            {
                ContractCreationDate = Convert.ToDateTime(contractCreationDate),
                StartDate = Convert.ToDateTime(startDate)
            };
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Contracts.Add(contract);
            }
            return true;
        }

        public double CalculateInsurancePrice(int landId, int contractId)
        {
            //rights?
            Contract contract = GetContractById(contractId);
            Land land = LandFunctions.GetLandById(landId);
            //some bullshit logic
            
            double price = land.PricePerSquareMeters * land.LocationPriceModifier * land.Size*land.Grain.Price;
            // ha enummal csináltam volna: Land.GrainType grainType = Land.GrainType.Barley;
            return price;
        }
    }
}