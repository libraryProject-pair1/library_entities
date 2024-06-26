using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using Domain;

namespace Application.Services.Categories;

public interface ICategoryService
{
    Task<Category?> GetAsync(
        Expression<Func<Category, bool>> predicate,
        Func<IQueryable<Category>, IIncludableQueryable<Category, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<Category>?> GetListAsync(
        Expression<Func<Category, bool>>? predicate = null,
        Func<IQueryable<Category>, IOrderedQueryable<Category>>? orderBy = null,
        Func<IQueryable<Category>, IIncludableQueryable<Category, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<Category> AddAsync(Category category);
    Task<Category> UpdateAsync(Category category);
    Task<Category> DeleteAsync(Category category, bool permanent = false);
}
