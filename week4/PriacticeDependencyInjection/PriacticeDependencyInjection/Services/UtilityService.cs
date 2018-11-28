using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriacticeDependencyInjection.Services
{
    public class UtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;
        public  bool isValidEmail;
        public string Email { set; get; }

        public UtilityService()
        {
            colors = new List<string>
            {
                "red",
                "blue",
                "lime",
                "orange",
                "magenta"
            };

            random = new Random();
        }

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }

        public bool ValidateEmail(string email)
        {
            Email = email;
            isValidEmail= email.Contains("@") && email.Contains(".");
            return isValidEmail;
        }
    }
}
