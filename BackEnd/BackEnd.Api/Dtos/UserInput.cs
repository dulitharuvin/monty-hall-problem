using System.ComponentModel.DataAnnotations;

namespace BackEnd.Api.Dtos
{
    public class UserInput
    {
        [Required]
        public int NumberOfSimulations { get; set; }

        [Required]
        public bool ChangeSelectedDoor { get; set; }
    }
}
