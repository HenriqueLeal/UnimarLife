using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnimarLife.Domain.NovaPasta;

namespace UnimarLife.Domain.AdministradorContext
{
    public class Administrador : User
    {
        public string? Cargo {get; set;}

    }
}
