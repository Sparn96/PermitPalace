using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PermitPalace.Models;

namespace PermitPalace.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<PERSONNEL_DATA> PERSONNEL_DATA { get; set; }
        public DbSet<PERMIT_DATA> PERMIT_DATA { get; set; }
        public DbSet<DOCUMENT_DATA> DOCUMENTS { get; set; }
        public DbSet<FILLED_DOCUMENT> FILED_DOCUMENT { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }

    public class DatabaseTable
    {
        public DateTime date_created { get; set; }
        public DateTime date_last_modified { get; set; }
        public string last_modified_by { get; set; }
        public string created_by { get; set; }
    }
}
