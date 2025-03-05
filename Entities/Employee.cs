
using System.ComponentModel.DataAnnotations;

namespace Api.Entities 
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public List<ShiftEmployee> ShiftEmployees {get; set; } = new();
        public List<TaskEmployee> TaskEmployees {get; set; } = new();
    }
}