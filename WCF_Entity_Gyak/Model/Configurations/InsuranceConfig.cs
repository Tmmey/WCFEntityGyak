using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WCF_Entity_Gyak.Model.Configurations
{
    public class InsuranceConfig : EntityTypeConfiguration<Insurance>
    {
        public InsuranceConfig()
        {
            this.HasKey(t=>t.Id);
        }
    }
}