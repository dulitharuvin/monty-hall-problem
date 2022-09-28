using System.ComponentModel.DataAnnotations;

namespace BackEnd.Dtos
{
    public class UserInput
    {
        [Required]
        public int NumberOfSimulations { get; set; }

        [Required]
        public bool ChangeSelectedDoor { get; set; }
    }
}
