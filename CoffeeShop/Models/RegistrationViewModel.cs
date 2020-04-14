using System;

namespace CoffeeShop.Models
{
    public class RegistrationViewModel
    {
        public RegistrationViewModel()
        {
        }

        public RegistrationViewModel(string username, string email, string password)
        {
            UserName = username;
            Email = email;
            Password = password;
        }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

}


