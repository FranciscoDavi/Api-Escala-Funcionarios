namespace Api.Entities
{
    public class ShiftTask
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public Tasks Task{ get; set; }
        public int ShiftId { get; set; }
        public Shift Shift { get; set; }
    }
}