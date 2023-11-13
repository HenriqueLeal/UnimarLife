using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnimarLife.Domain.PersonaContext;
using UnimarLife.Infra.MemoryDb.Interfaces;

namespace UnimarLife.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public ActionResult<List<Usuario>> GetAll()
        {
            return Ok(_usuarioRepository.GetUsuarios());
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> GetUsuarioById(int id)
        {
            return Ok(_usuarioRepository.GetUsuarioPorId(id));

        }

        [HttpPost]
        public ActionResult<Usuario> CreateUsuario(Usuario usuario)
        {
            _usuarioRepository.InsertUsuario(usuario);
            return CreatedAtAction(nameof(GetUsuarioById), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario == null)
                {
                    return BadRequest();

                }
                _usuarioRepository.UpdateUsuario(usuario);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        public ActionResult DeleteUsuario(int id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest();

                }
                _usuarioRepository.DeletaUsuario(id);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
