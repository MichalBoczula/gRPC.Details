namespace gRPC.Details.Client.Domain.Entities
{
    internal class ToDoList
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal int StatusId { get; set; }
        internal List<ToDoTask> Tasks { get; set; }
    }
}
