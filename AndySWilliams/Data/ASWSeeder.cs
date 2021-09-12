using AndySWilliams.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AndySWilliams.Data
{
    public class ASWSeeder
    {
        private readonly ASWContext _ctx;
        private readonly IWebHostEnvironment _env;

        public ASWSeeder(ASWContext ctx,IWebHostEnvironment env)
        {
            _ctx = ctx;
            _env = env;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();
            if (!_ctx.Families.Any())
            {
                var filePath = Path.Combine(_env.ContentRootPath,"Data/Family.json");
                var json = File.ReadAllText(filePath);
                var familyMembers = JsonSerializer.Deserialize<IEnumerable<Family>>(json);

                _ctx.Families.AddRange(familyMembers);

                _ctx.SaveChanges();
            }
        }
    }
}
