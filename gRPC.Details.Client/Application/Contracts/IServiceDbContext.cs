using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using gRPC.Details.Client.Domain.Entities;
using Microsoft.EntityFrameworkCore.Internal;

namespace gRPC.Details.Client.Application.Contracts
{
    internal interface IServiceDbContext
    {
        internal DbSet<ToDoList> ToDoLists { get; set; }
        internal DbSet<ToDoTask> ToDoTasks { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<IDbContextTransaction> BeginTransaction();
        Task CommitTransaction(IDbContextTransaction Transaction, CancellationToken cancellationToken);
        Task RollbackTransaction(IDbContextTransaction Transaction, CancellationToken cancellationToken);
    }
}
