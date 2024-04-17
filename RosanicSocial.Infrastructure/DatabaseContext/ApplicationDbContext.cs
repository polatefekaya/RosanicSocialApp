using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RosanicSocial.Domain.IdentityEntities;
using System;
using System.Collections.Generic;

namespace RosanicSocial.Infrastructure.DatabaseContext {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int> {
        public ApplicationDbContext(DbContextOptions options) : base(options) { 
        
        }

        public ApplicationDbContext() {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

        }
    }
}
