namespace gRPC.DeepDive.Service.Domain.Entities
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StatusId { get; set; }
        public int ToDoListId { get; set; }
        public ToDoList List { get; set; }
    }
}