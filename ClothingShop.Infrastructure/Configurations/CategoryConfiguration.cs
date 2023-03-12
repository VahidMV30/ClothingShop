using ClothingShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingShop.Infrastructure.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(110).IsRequired();
            builder.Property(x => x.Picture).HasMaxLength(500).IsRequired();
            builder.Property(x => x.PictureAlt).HasMaxLength(250).IsRequired();
            builder.Property(x => x.PictureTitle).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Keywords).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.MetaDescription).HasMaxLength(1000).IsRequired();
        }
    }
}
