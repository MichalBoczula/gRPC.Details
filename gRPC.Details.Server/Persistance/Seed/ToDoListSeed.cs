using gRPC.DeepDive.Service.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace gRPC.DeepDive.Service.Persistance.Seed
{
    public static class ToDoListSeed
    {
        public static void CreateToDoListSeed(this ModelBuilder modelBuilder)
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