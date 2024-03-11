using System.ComponentModel.DataAnnotations;

namespace Elias.Data.DTOs.UserDto
{
    public class ResumehDto
    {
        [Display(Name = "رزومه")]
        public string Resumeh { get; set; }
    }
}
