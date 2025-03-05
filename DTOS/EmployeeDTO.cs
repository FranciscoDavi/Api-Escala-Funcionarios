
using System.ComponentModel.DataAnnotations;
using Api.Entities;

namespace Api.DTOS
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set;}

        [Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set;}

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "The email provided is invalid")]
        public string Email { get; set;}
        public string Phone { get; set;} 
        public List<ShiftDTO> Shifts { get; set; } = new ();
        public List<TaskDTO> Tasks { get; set; } = new ();
    }
}