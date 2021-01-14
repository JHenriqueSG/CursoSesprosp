using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoSesprosp.Models
{
    public class Context : DbContext
    {

        public DbSet<Categoria> categorias { get; set;}
        //responsável por configurar o Entity framework
        public DbSet<Produto> Produtos { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=CursoSesprosp;Integrated Security=True");

    }
}
