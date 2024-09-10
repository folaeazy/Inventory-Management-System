using System.ComponentModel.DataAnnotations;


namespace Application.DTO.Request.Identity
{
    public class LoginUserRequestDTO
    {
        [EmailAddress]
        [RegularExpression("")]
        public string? Email {get; set ;}

        [Required]
        [RegularExpression("")]
        [MinLength(8), MaxLength(100)]
        public string? Password {get ; set ;}

        
    }
}