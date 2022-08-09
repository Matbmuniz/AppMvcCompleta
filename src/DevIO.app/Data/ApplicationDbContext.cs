using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DevIO.app.ViewModels;

namespace DevIO.app.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DevIO.app.ViewModels.FornecedorViewModel> FornecedorViewModel { get; set; }
        public DbSet<DevIO.app.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }
        public DbSet<DevIO.app.ViewModels.EnderecoViewModel> EnderecoViewModel { get; set; }
    }
}
