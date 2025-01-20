using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projectroom.Models;

namespace projectroom.Data
{
    public class projectroomContext : DbContext
    {
        public projectroomContext (DbContextOptions<projectroomContext> options)
            : base(options)
        {
        }

        public DbSet<projectroom.Models.Project> Project { get; set; } = default!;
    }
}
