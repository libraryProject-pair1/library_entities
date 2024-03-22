using NArchitecture.Core.Persistence.Repositories;


namespace Domain.Entities;
public class CatalogCategories :Entity<Guid>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Category {  get; set; }   

    public virtual Catalog Catalog { get; set; }
}
