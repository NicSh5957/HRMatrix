using HRMatrix.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMatrix.Domain.Configurations;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.HasKey(l => l.Id);
        builder.Property(l => l.Name).IsRequired().HasMaxLength(100);

        builder.HasData(
            new Language { Id = 1, Name = "Английский" },
            new Language { Id = 2, Name = "Турецкий" },
            new Language { Id = 3, Name = "Немецкий" },
            new Language { Id = 4, Name = "Китайский" }
        );
    }
}