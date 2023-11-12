using BibleVerseApp.Models;
using System.Text.Json;

namespace CLCMilestone.Services
{
    public class SecurityService
    {
        SecurityDAO securityDAO = new SecurityDAO();
        public bool isValid(Login User)
        {
            return securityDAO.FindUserByNameAndPassword(User);
        }

        public void RegisterUser (Register User)
        {
           securityDAO.RegisterUser(User);
        }

        internal async Task CreateDocument(string json)
        {
           
        }
    }
}
