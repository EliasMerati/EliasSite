using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elias.Data.DTOs.UserDto
{
   public class AboutMeInfoDto
    {
        public string Name { get; set; }
        public string Familly { get; set; }
        public string BirthDay { get; set; }
        public string City { get; set; }
        public string MainDescription { get; set; }
        public string MainSkill { get; set; }
        public string Skype { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class SocialDto
    {
        public string GitHub { get; set; }
        public string LinkedIn { get; set; }
    }

    public class MainInfoDto
    {
        public string Name { get; set; }
        public string Familly { get; set; }
        public string Skills { get; set; }
    }
}
