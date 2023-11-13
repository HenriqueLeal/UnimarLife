using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnimarLife.Domain.NovaPasta;

namespace UnimarLife.Domain.PersonaContext
{
    public class Academico : User
    {
        public int? RaAcademico { get; set; }
        public string? CursoAcademico { get; set; }

    }
}
