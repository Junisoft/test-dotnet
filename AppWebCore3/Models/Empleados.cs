using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebCore3.Models
{
    public class Empleados
    {
        [Key]
        public int id_emp { get; set; } //SongId or Id asi automaticamente lo reconoce como PK
        public string nombre_emp { get; set; }
        public string apellidos_emp { get; set; }
        public string salario_emp { get; set; }
    }
}
