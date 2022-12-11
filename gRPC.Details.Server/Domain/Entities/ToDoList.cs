namespace gRPC.DeepDive.Service.Domain.Entities
{
    public class ToDoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StatusId { get; set; }
        public List<ToDoTask> Tasks { get; set; }
    }
}
