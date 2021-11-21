using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReviewsAndRatings.DTO
{
    public class LoginUserDTO
    {
        [Required(ErrorMessage = "The field {0} is required!")]
        [EmailAddress(ErrorMessage = "The field {0} is not in a valid format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field {0} is required!")]
        [StringLength(100, ErrorMessage = "The field {0} need to have between {2} and {1} characterer.", MinimumLength = 6)]
        public string Password { get; set; }
    }

    public class RegisterUserDTO : LoginUserDTO
    {
        [Compare("Password", ErrorMessage = "The password informed does not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class UserTokenDTO
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<ClaimDTO> Claims { get; set; }
    }

    public class LoginResponseDTO
    {
        public string AccessToken { get; set; }
        public double ExpiresIn { get; set; }
        public UserTokenDTO UserToken { get; set; }
    }

    public class ClaimDTO
    {
        public string Value { get; set; }
        public string Type { get; set; }
    }
}