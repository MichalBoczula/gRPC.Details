namespace gRPC.Details.Client.Domain.Entities
{
    internal class ToDoTask
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal int StatusId { get; set; }
        internal int ToDoListId { get; set; }
        internal ToDoList List { get; set; }
    }
}
