using System.ComponentModel.DataAnnotations;

namespace MyPatchSG.API.Models
{
    public class GetFileNameParameter
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string AppID { get; set; }
        [Required]
        public string OS { get; set; }

    }
}