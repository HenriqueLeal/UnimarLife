using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnimarLife.Domain.PersonaContext;

namespace UnimarLife.Infra.MemoryDb.Interfaces
{
    public interface IAcademicoRepository
    {
        public List<Academico> GetAcademicos();
        public Academico GetAcademicoPorId(int id);
        public void InsertAcademico(Academico academico);
        public void UpdateAcademico(Academico academico);
        public void DeletaAcademico(int id);
    }
}
