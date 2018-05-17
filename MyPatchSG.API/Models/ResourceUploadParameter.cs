using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyPatchSG.API.Models
{
    public class ResourceUploadParameter
    {
        [Required]
        public string FileName { get; set; }
    }
}