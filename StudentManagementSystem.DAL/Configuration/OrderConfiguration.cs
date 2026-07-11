using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL.Configuration;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasOne(o => o.Customer)
            .WithMany(o => o.Orders)
            .HasForeignKey(o => o.CustoerId)
            .IsRequired();
        builder.HasMany(o => o.Items)
            .WithOne(o => o.Order)
            .HasForeignKey(o => o.orderId)
            .IsRequired();


    }
}
