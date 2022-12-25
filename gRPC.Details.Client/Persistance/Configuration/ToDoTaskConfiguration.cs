using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using gRPC.Details.Client.Domain.Entities;

namespace gRPC.Details.Client.Persistance.Configuration
{
    internal class ToDoTaskConfiguration : IEntityTypeConfiguration<ToDoTask>
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
