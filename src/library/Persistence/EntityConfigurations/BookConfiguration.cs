using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books").HasKey(b => b.Id);

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.ISBN).HasColumnName("ISBN");
        builder.Property(b => b.NumberOfPages).HasColumnName("NumberOfPages");
        builder.Property(b => b.BookTitle).HasColumnName("BookTitle");
        builder.Property(b => b.Status).HasColumnName("Status");
        builder.Property(b => b.MemberId).HasColumnName("MemberId");
        builder.Property(b => b.AuthorId).HasColumnName("AuthorId");
        builder.Property(b => b.PublisherId).HasColumnName("PublisherId");
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}