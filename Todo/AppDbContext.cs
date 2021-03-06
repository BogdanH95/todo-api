﻿using Microsoft.EntityFrameworkCore;

namespace Todo
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Models.Todo> Todos { get; set; }
    }

}
