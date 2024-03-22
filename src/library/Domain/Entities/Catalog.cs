using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class Catalog:Entity<Guid>
{
    public string CatalogTypes { get; set; }
    public ICollection<CatalogCategories> CatalogCategories { get; set; }
    public Guid BookId {  get; set; }
    public virtual ICollection<Book> Book { get; set; } = null;
}