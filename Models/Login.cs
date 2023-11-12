using System.ComponentModel;

namespace BibleVerseApp.Models
{
    public class Login
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        [DisplayName("Username")]
        public string Username { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }

        public Login(int id, string firstName, string lastName, string sex, int age, string state, string email, string username, string password)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Sex = sex;
            this.Age = age;
            this.State = state;
            this.Email = email;
            this.Username = username;
            this.Password = password;
        }

        public Login()
        {

        }
    }
}
