using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroLibro.Entidades
{
    public class Libros
    {
        [Key]
        public int LibroId { get; set; }
        public String Descripcion { get; set; }
        public String Siglas { get; set; }


        public Libros()
        {
            LibroId = 0;
            Descripcion = string.Empty;
            Siglas = string.Empty;

        }
    }
}
