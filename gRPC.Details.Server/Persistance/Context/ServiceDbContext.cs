using gRPC.Details.Service.Application.Contracts;
using gRPC.Details.Service.Domain.Entities;
using gRPC.Details.Service.Persistance.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace gRPC.Details.Service.Persistance.Context
{
    internal class ServiceDbContext : DbContext, IServiceDbContext
    {
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<ToDoTask> ToDoTasks { get; set; }

        public ServiceDbContext([NotNull] DbContextOptions<ServiceDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.CreateToDoListSeed();
            modelBuilder.CreateToDoTaskSeed();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        public async Task<IDbContextTransaction> BeginTransaction()
        {
            return await this.Database.BeginTransactionAsync();
        }

        public async Task CommitTransaction(IDbContextTransaction Transaction, CancellationToken cancellationToken)
        {
            await Transaction.CommitAsync(cancellationToken);
        }

        public async Task RollbackTransaction(IDbContextTransaction Transaction, CancellationToken cancellationToken)
        {
            await Transaction.RollbackAsync(cancellationToken);
        }
    }
}
