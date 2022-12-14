using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using gRPC.Details.Service.Domain.Entities;

namespace gRPC.Details.Service.Application.Contracts
{
    internal interface IServiceDbContext
    {
        DbSet<ToDoList> ToDoLists { get; set; }
        DbSet<ToDoTask> ToDoTasks { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<IDbContextTransaction> BeginTransaction();
        Task CommitTransaction(IDbContextTransaction Transaction, CancellationToken cancellationToken);
        Task RollbackTransaction(IDbContextTransaction Transaction, CancellationToken cancellationToken);
    }
}
