using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnimarLife.Domain.AdministradorContext;
using UnimarLife.Infra.Interfaces;

namespace UnimarLife.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministradorController : ControllerBase
    {

        readonly IAdministradorRepository _administradorRepository;

        public AdministradorController(IAdministradorRepository administradorRepository)
        {
            _administradorRepository = administradorRepository;
        }

        [HttpGet]
        public ActionResult<List<Administrador>> GetAll() 
        { 
            return Ok(_administradorRepository.GetAdministradores());
        }

        [HttpGet("{id}")]
        public ActionResult <Administrador> GetAdministradorById(int id)
        {
            return Ok(_administradorRepository.GetAdministradorPorId(id));

        }

        [HttpPost]
        public ActionResult<Administrador> CreateAdministrador(Administrador administrador)
        {
            _administradorRepository.InsertAdministrador(administrador);
            return CreatedAtAction(nameof(GetAdministradorById), new { id = administrador.Id }, administrador);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] Administrador administrador)
        {
            try
            {
                if (administrador == null)
                {
                    return BadRequest();

                }
                _administradorRepository.UpdateAdministrador(administrador);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        public ActionResult DeleteAdministrador(int id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest();

                }
                _administradorRepository.DeletaAdministrador(id);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
