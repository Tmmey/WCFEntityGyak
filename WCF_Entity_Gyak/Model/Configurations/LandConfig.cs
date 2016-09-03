using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WCF_Entity_Gyak.Model.Configurations
{
    public class LandConfig: EntityTypeConfiguration<Land>
    {
        public LandConfig()
        {
            this.HasKey(t => t.Id);
        }
    }
}