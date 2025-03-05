

namespace Api.Entities
{
    public class Shift
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set; }
        public List<ShiftEmployee> ShiftEmployees {get; set; } = new ();
         public List<ShiftTask> ShiftTasks {get; set; } = new ();
    }
}