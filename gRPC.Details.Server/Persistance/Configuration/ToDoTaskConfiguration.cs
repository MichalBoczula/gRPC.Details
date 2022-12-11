using gRPC.DeepDive.Service.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gRPC.DeepDive.Service.Persistance.Configuration
{
    public class ToDoTaskConfiguration : IEntityTypeConfiguration<ToDoTask>
    {
        public void Configure(EntityTypeBuilder<ToDoTask> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.List)
                .WithMany(x => x.Tasks)
                .HasForeignKey(x => x.ToDoListId);
        }
    }
}
