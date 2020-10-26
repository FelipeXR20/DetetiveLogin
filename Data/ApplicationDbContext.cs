using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DetetiveLogin.Models;

namespace DetetiveLogin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DetetiveLogin.Models.TipoUsuario> TipoUsuario { get; set; }
        public DbSet<DetetiveLogin.Models.AcessoTipoUsuario> AcessoTipoUsuario { get; set; }
        public DbSet<DetetiveLogin.Models.PerfilUsuario> PerfilUsuario { get; set; }
    }
}
