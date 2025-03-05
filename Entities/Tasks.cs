
namespace Api.Entities
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public List<TaskEmployee> TaskEmployees {get; set; } = new ();
        public List<ShiftTask> ShiftTasks {get; set;} = new ();

    }

}