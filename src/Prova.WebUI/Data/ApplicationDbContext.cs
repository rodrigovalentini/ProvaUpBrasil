using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Prova.WebUI.ViewModels;

namespace Prova.WebUI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Prova.WebUI.ViewModels.UfViewModel> UfViewModel { get; set; }
        public DbSet<Prova.WebUI.ViewModels.ClienteViewModel> ClienteViewModel { get; set; }
    }
}
