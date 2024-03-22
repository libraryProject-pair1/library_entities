using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class Author:Entity<Guid>
{
    public string name { get; set; }
    public virtual ICollection<Book> Book { get; set; } = null;   
}