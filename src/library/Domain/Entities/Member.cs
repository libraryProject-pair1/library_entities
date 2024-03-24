

using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Member : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public virtual ICollection<Book> Book { get; set; } = null;  
}
