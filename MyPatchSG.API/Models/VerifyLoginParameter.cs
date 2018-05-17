using System.ComponentModel.DataAnnotations;

namespace MyPatchSG.API.Models
{
    public class VerifyLoginParameter
    {
        [Required]
        public string UserID { get; set; }
        [Required]
        public string Password { get; set; }
        
        public string MacAddr { get; set; }
    }
}