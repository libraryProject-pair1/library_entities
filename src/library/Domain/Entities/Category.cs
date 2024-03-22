using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Domain;

public class Category:Entity<Guid>
{
    public string name {  get; set; }   
    public virtual ICollection<Book> Book {  get; set; }    
}