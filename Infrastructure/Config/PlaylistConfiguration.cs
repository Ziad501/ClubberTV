using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class PlayListConfiguration : IEntityTypeConfiguration<PlayList>
    {
        public void Configure(EntityTypeBuilder<PlayList> builder)
        {
            builder.ToTable("PlayLists");

            builder.HasKey(p => new { p.UserId, p.MatchId });

            builder.HasOne(p => p.User)
                   .WithMany(u => u.PlayLists)
                   .HasForeignKey(p => p.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Match)
                   .WithMany()
                   .HasForeignKey(p => p.MatchId)
                   .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
