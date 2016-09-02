using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_Entity_Gyak.Model;

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
    }
}