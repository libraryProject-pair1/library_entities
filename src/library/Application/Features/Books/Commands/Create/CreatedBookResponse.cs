using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.Books.Commands.Create;

public class CreatedBookResponse : IResponse
{
    public Guid Id { get; set; }
    public string ISBN { get; set; }
    public int NumberOfPages { get; set; }
    public string BookTitle { get; set; }
    public BookStatus Status { get; set; }
    public Guid MemberId { get; set; }
    public Guid AuthorId { get; set; }
    public Guid PublisherId { get; set; }
}