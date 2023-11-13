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
    public class AcademicoRepository : IAcademicoRepository
    {
        private readonly UnimarLifeDBMemoryContext _context;

        public AcademicoRepository(UnimarLifeDBMemoryContext context)
        {
            _context = context;

        }

        public List<Academico> GetAcademicos()
        {
            return _context.Academicos.ToList();
        }

        public Academico GetAcademicoPorId(int id)
        {
            return _context.Academicos.Find(id);
        }

        public void InsertAcademico(Academico academico)
        {
            try
            {
                _context.Academicos.Add(academico);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }



        public void UpdateAcademico(Academico academico)
        {
            try
            {
                _context.Academicos.Entry(academico).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletaAcademico(int id)
        {
            var inativo = _context.Academicos.Find(id);
            if (inativo != null)
            {
                inativo.Ativo = false;
                _context.SaveChanges();
            }
        }


    }
}
