using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyPatchSG.API
{
    public class MyPatchSGWebContext : DbContext
    {
        public MyPatchSGWebContext(string conString)
        {
            var str = Settings.GetConnectionString(conString);
            this.Database.Connection.ConnectionString = str;
        }
    }
}