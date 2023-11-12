using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BibleVerseApp.Models
{
    public class Register
    {
        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }
        [DisplayName("Gender")]
        [Required]
        public string Sex { get; set; }
        [DisplayName("Age")]
        [Required]
        public int Age { get; set; }
        [DisplayName("State")]
        [Required]
        public string State { get; set; }
        [DisplayName("Email")]
        [Required]
        public string Email { get; set; }
        [DisplayName("Username")]
        [Required]
        public string Username { get; set; }
        [DisplayName("Password")]
        [Required]
        public string Password { get; set; }

        public Register()
        {

        }

        public Register(string firstName, string lastName, string sex, int age, string state, string email, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            Age = age;
            State = state;
            Email = email;
            Username = username;
            Password = password;
        }
    }
}
