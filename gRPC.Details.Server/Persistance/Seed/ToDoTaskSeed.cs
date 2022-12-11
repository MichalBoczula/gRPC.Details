using gRPC.DeepDive.Service.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace gRPC.DeepDive.Service.Persistance.Seed
{
    public static class ToDoTaskSeed
    {
        public static void CreateToDoTaskSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoTask>()
                .HasData(new ToDoTask
                {
                    Id = 1,
                    Name = "First",
                    StatusId = 1,
                    ToDoListId = 1,
                });

            modelBuilder.Entity<ToDoTask>()
                .HasData(new ToDoTask
                {
                    Id = 2,
                    Name = "Second",
                    StatusId = 1,
                    ToDoListId = 1,
                });

            modelBuilder.Entity<ToDoTask>()
                .HasData(new ToDoTask
                {
                    Id = 3,
                    Name = "Third",
                    StatusId = 2,
                    ToDoListId = 1,
                });
        }
    }
}