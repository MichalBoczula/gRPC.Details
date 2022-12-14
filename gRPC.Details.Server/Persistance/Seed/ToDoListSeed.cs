using gRPC.Details.Service.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace gRPC.Details.Service.Persistance.Seed
{
    internal static class ToDoListSeed
    {
        internal static void CreateToDoListSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoList>()
                .HasData(new ToDoList
                {
                    Id = 1,
                    Name = "Initial",
                    StatusId = 1,
                });
        }
    }
}