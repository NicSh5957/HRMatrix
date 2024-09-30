using HRMatrix.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMatrix.Domain.Configurations;

public class MaritalStatusConfiguration : IEntityTypeConfiguration<MaritalStatus>
{
    public void Configure(EntityTypeBuilder<MaritalStatus> builder)
    {
        builder.HasKey(ms => ms.Id);
        builder.Property(ms => ms.Name).IsRequired().HasMaxLength(100);

        builder.HasData(
            new MaritalStatus { Id = 1, Name = "Женат/Замужем" },
            new MaritalStatus { Id = 2, Name = "Холост/Не замужем" },
            new MaritalStatus { Id = 3, Name = "Разведен(а)" }
        );
    }
}