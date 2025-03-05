using System.ComponentModel.DataAnnotations;

namespace Api.DTOS
{
    public class ShiftTaskDTO
    {
        [Required]
        public int ShiftId { get; set; }

        [Required]
        public int TaskId { get; set; }
       
    }
}