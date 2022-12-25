using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using gRPC.Details.Client.Domain.Entities;

namespace gRPC.Details.Client.Persistance.Configuration
{
    internal class ToDoListConfiguration : IEntityTypeConfiguration<ToDoList>
    {
        public void Configure(EntityTypeBuilder<ToDoList> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
