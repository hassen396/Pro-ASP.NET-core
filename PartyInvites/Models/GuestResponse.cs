using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models{
public class GuestResponse {



    [Required(ErrorMessage = "Please enter Your name")]
    public string? Name { get; set; }


    [Required(ErrorMessage = "Please enter your email")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Please enter your phone number")]
    public string? Phone { get; set; }

    [Required(ErrorMessage = "Please choose if you will attend")]
    public bool? WillAttend { get; set; }
}
}