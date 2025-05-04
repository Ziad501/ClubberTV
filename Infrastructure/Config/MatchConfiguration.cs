using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.ToTable("Matches");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Title)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(m => m.Competition)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(m => m.Status)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(m => m.Date)
                   .IsRequired();
        }
    }
}
