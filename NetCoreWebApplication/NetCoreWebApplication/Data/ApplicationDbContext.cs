using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetCoreWebApplication.Models;

namespace NetCoreWebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NetCoreWebApplication.Models.PPData> PPData { get; set; }
        public DbSet<NetCoreWebApplication.Models.JobData> JobData { get; set; }
    }
}
