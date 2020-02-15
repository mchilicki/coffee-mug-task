using Chilicki.CoffeeMugTask.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Data.Configurations.EntityConfigurations
{
    public class ProductConfiguration : BaseEntityConfiguration<Product>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(p => p.Price)
                .IsRequired();
        }
    }
}
