using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using System.Data.Entity.Infrastructure.Annotations;

namespace WCF_Entity_Gyak.Model.Configurations
{
    public class UserConfig:EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            this.HasKey(t=>t.Id);
            this.Property(t => t.IdentityCardNumber).IsRequired();
            this.Property(t => t.IdentityCardNumber).HasColumnName("ICN");
            //this.Property(t => t.IdentityCardNumber).HasColumnAnnotation(
            //    IndexAnnotation.AnnotationName, new IndexAnnotation(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute("IX_IdentityCardNumber", 1) { IsUnique = true }));


        }
    }
}