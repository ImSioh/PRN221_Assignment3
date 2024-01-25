using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _29_PhamThiNgocMai_Assignment3.Models;

namespace _29_PhamThiNgocMai_Assignment3.Models
{
    public class _29_PhamThiNgocMai_Assignment3Context : DbContext
    {
        public _29_PhamThiNgocMai_Assignment3Context (DbContextOptions<_29_PhamThiNgocMai_Assignment3Context> options)
            : base(options)
        {
        }

        public DbSet<_29_PhamThiNgocMai_Assignment3.Models.AppUser> AppUser { get; set; } = default!;

        public DbSet<_29_PhamThiNgocMai_Assignment3.Models.PostCategory>? PostCategory { get; set; }

        public DbSet<_29_PhamThiNgocMai_Assignment3.Models.Post>? Post { get; set; }
    }
}
