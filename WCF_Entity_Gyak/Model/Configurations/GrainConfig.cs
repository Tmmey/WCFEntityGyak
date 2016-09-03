using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace WCF_Entity_Gyak.Model.Configurations
{
    public class GrainConfig:EntityTypeConfiguration<Grain>
    {
        public GrainConfig()
        {
            this.HasKey(t => t.Id);
        }
    }
}