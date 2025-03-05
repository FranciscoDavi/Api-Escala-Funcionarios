namespace Api.DTOS
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public List<string> Employees {get; set; } = new ();
        public List<string> Shifts {get; set; } = new ();
    }
}