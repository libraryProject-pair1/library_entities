using Domain;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface ICategoryRepository : IAsyncRepository<Category, Guid>, IRepository<Category, Guid>
{
}