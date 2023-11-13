using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnimarLife.Domain.PersonaContext;
using UnimarLife.Infra.Interfaces;
using UnimarLife.Infra.MemoryDb.Interfaces;

namespace UnimarLife.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicoController : ControllerBase
    {
        readonly IAcademicoRepository _academicoRepository;

        public AcademicoController(IAcademicoRepository academicoRepository)
        {
            _academicoRepository = academicoRepository;
        }

        [HttpGet]
        public ActionResult<List<Academico>> GetAll()
        {
            return Ok(_academicoRepository.GetAcademicos());
        }

        [HttpGet("{id}")]
        public ActionResult<Academico> GetAdministradorById(int id)
        {
            return Ok(_academicoRepository.GetAcademicoPorId(id));

        }

        [HttpPost]
        public ActionResult<Academico> CreateAcademico(Academico academico)
        {
            _academicoRepository.InsertAcademico(academico);
            return CreatedAtAction(nameof(GetAdministradorById), new { id = academico.Id }, academico);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] Academico academico)
        {
            try
            {
                if (academico == null)
                {
                    return BadRequest();

                }
                _academicoRepository.UpdateAcademico(academico);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        public ActionResult DeleteAcademico(int id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest();

                }
                _academicoRepository.DeletaAcademico(id);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
