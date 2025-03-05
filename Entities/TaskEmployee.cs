namespace Api.Entities
{
    public class TaskEmployee
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public Tasks Task{ get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee{ get; set; }
     
    }
}