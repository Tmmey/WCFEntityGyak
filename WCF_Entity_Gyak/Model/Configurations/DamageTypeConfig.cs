using System.Data.Entity.ModelConfiguration;
using WCF_Entity_Gyak.Model;

namespace WCF_Entity_Gyak
{
    internal class DamageTypeConfig : EntityTypeConfiguration<DamageType>
    {
        public DamageTypeConfig()
        {
            this.HasKey(t => t.Id);
        }
    }
}