using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnimarLife.Domain.AdministradorContext;
using UnimarLife.Infra.Interfaces;
using UnimarLife.Infra.MemoryDb;

namespace UnimarLife.Infra.Repositories
{
    public class AdministradorRepository : IAdministradorRepository
    {
        private readonly UnimarLifeDBMemoryContext _context;

        public AdministradorRepository(UnimarLifeDBMemoryContext context)
        {
            _context = context;

        }

        public List<Administrador> GetAdministradores()
        {
            return _context.Administradores.ToList();
        }

        public Administrador GetAdministradorPorId(int id)
        {
            return _context.Administradores.Find(id);
        }

        public void InsertAdministrador(Administrador administrador)
        {
            try
            {
                _context.Administradores.Add(administrador);
                _context.SaveChanges();
               
            }
            catch (Exception)
            {
                throw;
            }
        }
            
            

        public void UpdateAdministrador(Administrador administrador)
        {
            try
            {
                _context.Administradores.Entry(administrador).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletaAdministrador(int id)
        {
            var inativo = _context.Administradores.Find(id);
            if (inativo != null)
            {
                inativo.Ativo = false;
                _context.SaveChanges();
            }
        }

        
    }
}
