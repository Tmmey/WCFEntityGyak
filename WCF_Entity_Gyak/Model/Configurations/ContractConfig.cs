using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WCF_Entity_Gyak.Model.Configurations
{
    public class ContractConfig: EntityTypeConfiguration<Contract>
    {
        public ContractConfig()
        {
            this.HasKey(t=>t.Id);
            this.Property(t => t.ContractCreationDate).HasColumnType(DataType.DateTime.ToString());
        }
    }
}