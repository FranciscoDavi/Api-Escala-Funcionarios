
namespace Api.DTOS
{
    public class ShiftDTO
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public DateTime Start_Time{ get; set; }   
        public DateTime End_Time {get; set; }

        public List<EmployeeDTO> Employees { get; set;} = new();
        public List<TaskDTO> Tasks { get; set;} = new();
       
    }
}