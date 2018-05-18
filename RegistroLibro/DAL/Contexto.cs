using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroLibro.Entidades;
using System.Data.Entity;

namespace RegistroLibro.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Libros> Libros { get; set; }

        public Contexto() : base("ConStr") { }
    }
}
