using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using MyPatchSG.API.Models;

namespace MyPatchSG.API.Entities
{
    public class AppInfo
    {
        [Key]
        public string Id { get; set; }

        [MaxLength(100)]
        public string ClientOS { get; set; }

        [MaxLength(10)]
        public string Version { get; set; }

        [MaxLength(500)]
        public string AppStoreURL { get; set; }

        public bool ForceUpdate { get; set; }

        [MaxLength(500)]
        public string Remark { get; set; }
    }
}