namespace MyPatchSG.API.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;

    using MyPatchSG.API.Entities;
    using MyPatchSG.API.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MyPatchSG.API.AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MyPatchSG.API.AuthContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var baseDir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin", string.Empty) + "\\Migrations";

            try
            {
                var commands = File.ReadAllText(baseDir + "\\PredefinedData.sql");
                commands = commands.Replace("GO", string.Empty);
                context.Database.ExecuteSqlCommand(commands);
            }
            catch (Exception ex)
            {

            }

            GenerateData(context);
        }

        public static void GenerateData(AuthContext context)
        {
            if (!context.Clients.Any())
            {
                context.Clients.AddRange(BuildClientsList());
            }

            context.SaveChanges();
        }

        private static List<Client> BuildClientsList()
        {
            List<Client> ClientsList = new List<Client>
                                       {
                                           new Client
                                           {
                                               Id = "TestMyPatchSGClient",
                                               Secret = Helper.GetHash("SecretKey"),
                                               Name = "Test Web MyPatchSG API client",
                                               ApplicationType = ApplicationTypes.JavaScript,
                                               Active = true,
                                               RefreshTokenLifeTime = 7200,
                                               AllowedOrigin = "http://localhost"
                                           },
                                           new Client
                                           {
                                               Id = "TestNativeMyPatchSGClient",
                                               Secret = Helper.GetHash("123@abc"),
                                               Name = "Test Native MyPatchSG Client",
                                               ApplicationType = ApplicationTypes.NativeConfidential,
                                               Active = true,
                                               RefreshTokenLifeTime = 14400,
                                               AllowedOrigin = "*"
                                           }
                                       };

            return ClientsList;
        }
    }
}
