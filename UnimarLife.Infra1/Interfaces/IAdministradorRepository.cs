using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnimarLife.Domain.AdministradorContext;

namespace UnimarLife.Infra.Interfaces
{
    public interface IAdministradorRepository
    {
        public List<Administrador> GetAdministradores();
        public Administrador GetAdministradorPorId(int id);
        public void InsertAdministrador(Administrador administrador);
        public void UpdateAdministrador(Administrador administrador);
        public void DeletaAdministrador(int id);
    }
   }
