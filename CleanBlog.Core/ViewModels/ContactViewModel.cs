using System.ComponentModel.DataAnnotations;


namespace CleanBlog.Core.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Pease enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pease enter your email address")]
        [EmailAddress(ErrorMessage = "You must enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pease enter your message")]
        [MaxLength(500, ErrorMessage="Your message should not be longer than 500 characters")]
        public string Message { get; set; }

        public int ContactFormId { get; set; }
    }
}
