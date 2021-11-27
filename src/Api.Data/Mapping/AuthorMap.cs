using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class AuthorMap : IEntityTypeConfiguration<AuthorEntity>
    {

        public void Configure(EntityTypeBuilder<AuthorEntity> builder)
        {
            builder.ToTable("Author");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}