using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnimarLife.Domain.PersonaContext;
using UnimarLife.Infra.Interfaces;
using UnimarLife.Infra.MemoryDb.Interfaces;

namespace UnimarLife.Infra.MemoryDb.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UnimarLifeDBMemoryContext _context;

        public UsuarioRepository(UnimarLifeDBMemoryContext context)
        {
            _context = context;

        }

        public List<Usuario> GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario GetUsuarioPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void InsertUsuario(Usuario usuario)
        {
            try
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }



        public void UpdateUsuario(Usuario usuario)
        {
            try
            {
                _context.Usuarios.Entry(usuario).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletaUsuario(int id)
        {
            var inativo = _context.Usuarios.Find(id);
            if (inativo != null)
            {
                inativo.Ativo = false;
                _context.SaveChanges();
            }
        }


    }
}




