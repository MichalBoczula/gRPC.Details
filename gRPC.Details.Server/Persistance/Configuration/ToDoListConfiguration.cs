using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using gRPC.DeepDive.Service.Domain.Entities;

namespace gRPC.DeepDive.Service.Persistance.Configuration
{
    public class ToDoListConfiguration : IEntityTypeConfiguration<ToDoList>
    {
        public void Configure(EntityTypeBuilder<ToDoList> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
