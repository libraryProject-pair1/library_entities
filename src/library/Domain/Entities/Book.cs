using Domain.Enums;
using NArchitecture.Core.Persistence.Repositories;
using System;


namespace Domain.Entities;
public class Book : Entity<Guid>
{
    public string ISBN { get; set; }
    public int NumberOfPages { get; set; }
    public string BookTitle { get; set; }
    public BookStatus Status { get; set; }
    public Guid MemberId { get; set; }
    public virtual Member? Member { get; set; }
    public Guid AuthorId { get; set; }
    public virtual Author? Author { get; set; }
    public Guid PublisherId { get; set; }
    public virtual Publisher? Publisher { get; set; }
    
    public virtual ICollection<Category> Category { get; set; }
}
