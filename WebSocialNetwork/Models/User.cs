using Microsoft.AspNetCore.Identity;

namespace WebSocialNetwork.Views
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public DateTime BirthDate { get; set; }

        public string Image { get; set; }

        public string Status { get; set; }

        public string About { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public User()
        {
            Image = "https://mobimg.b-cdn.net/v3/fetch/76/76789104c7c3e565cdca3895537e0172.jpeg";
            Status = "Ура! Я в соцсети!";
            About = "Информация обо мне.";
        }
    }
}
