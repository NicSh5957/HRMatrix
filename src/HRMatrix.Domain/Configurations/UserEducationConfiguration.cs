using HRMatrix.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HRMatrix.Domain.Configurations;

public class UserEducationConfiguration : IEntityTypeConfiguration<UserEducation>
{
    public void Configure(EntityTypeBuilder<UserEducation> builder)
    {
        builder.HasKey(ue => ue.Id);
        builder.HasOne(ue => ue.UserProfile)
            .WithMany(up => up.UserEducations)
            .HasForeignKey(ue => ue.UserProfileId);

        builder.HasOne(ue => ue.EducationLevel)
            .WithMany()
            .HasForeignKey(ue => ue.EducationLevelId);

        builder.Property(ue => ue.Quantity).IsRequired();
    }
}