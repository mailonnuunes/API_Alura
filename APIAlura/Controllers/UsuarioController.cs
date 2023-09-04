

using APIAlura.Entidade;
using APIAlura.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIAlura.Controllers
{
    [ApiController]
    [Route("Usuario")]

   
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }


        [HttpGet("Obter-todos-os-usuarios")]
        public IActionResult ChamarTodosUsuarios()
        {
            return Ok(_usuarioRepository.ObterTodosUsuarios());
        }
        [HttpGet("Obter-usuario-por-id/{id}")]
        public IActionResult ChamarUsuarioID(int id)
        {
            return Ok(_usuarioRepository.ObterUsuarioPorId(id));
        }
        [HttpPut]
        public void CadastrarUsuario([FromBody]Usuario usuario)
        {
            _usuarioRepository.CadastrarUsuario(usuario);

        }
        [HttpPost]
        public void EditarUsuario([FromBody]Usuario usuario)
        {
            _usuarioRepository.AlterarUsuario(usuario);
        }
        [HttpDelete]
        public void ExcluirUsuario(int id)
        {
            _usuarioRepository.DeletarUsuario(id);
        }
    }
}
