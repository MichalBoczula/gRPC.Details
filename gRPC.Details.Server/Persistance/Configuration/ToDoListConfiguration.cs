using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using gRPC.Details.Service.Domain.Entities;

namespace gRPC.Details.Service.Persistance.Configuration
{
    internal class ToDoListConfiguration : IEntityTypeConfiguration<ToDoList>
    {
        public void Configure(EntityTypeBuilder<ToDoList> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
