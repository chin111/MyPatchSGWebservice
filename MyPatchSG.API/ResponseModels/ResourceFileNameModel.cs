using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MyPatchSG.API.StoredProcedures;

namespace MyPatchSG.API.ResponseModels
{
    public class ResourceFileNameModel
    {
        public string UserName { get; set; }
        public List<DBFileNameModel> DbFileNames { get; set; }
    }
}