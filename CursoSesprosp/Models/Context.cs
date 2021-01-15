using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoSesprosp.Models
{
    public class Context : DbContext
    {

        public virtual DbSet<Categoria> Categorias { get; set;}
        //responsável por configurar o Entity framework
        public virtual DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=CursoSesprosp;Integrated Security=True");

        public void FindAsync(int v)
        {
            throw new NotImplementedException();
        }

        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
