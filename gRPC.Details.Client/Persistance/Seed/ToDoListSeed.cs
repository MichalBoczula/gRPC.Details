using gRPC.Details.Client.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace gRPC.Details.Client.Persistance.Seed
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
