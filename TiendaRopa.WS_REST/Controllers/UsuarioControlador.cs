using Microsoft.AspNetCore.Mvc;
using TiendaRopa.Aplicacion.Aplicacion.Servicio;
using TiendaRopa.Aplicacion.Aplicacion.ServicioImpl;
using TiendaRopa.Infraestructura.AccesoDatos;

namespace TiendaRopa.WS_REST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioControlador
    {
        private readonly BD_ModaEcContext _dbcontext;
        private readonly IUsuarioServicio _usuarioServicio;

        public UsuarioControlador(BD_ModaEcContext dbcontext)
        {
            _dbcontext = dbcontext;
            _usuarioServicio = new UsuarioServicioImpl(_dbcontext);
        }

        [HttpGet("ListarUsuarios")]
        public IEnumerable<Usuario> GetListarUsuarios()
        {

            return _usuarioServicio.GetAllAsync().GetAwaiter().GetResult();
        }

        [HttpGet("ListarUsuariosEstado")]
        public IEnumerable<Usuario> GetListarUsuariosEstado(string estado)
        {

            return _usuarioServicio.ListarUsuarioPorEstado(estado);
        }


        [HttpGet("ListarUsuariosNick")]
        public IEnumerable<Usuario> GetListarUsuariosNick(string nick)
        {

            return _usuarioServicio.ListarUsuarioPorUser(nick);
        }

        [HttpPost("IngresaUsuario")]
        public async Task PostIngresaUsuario(Usuario entity)
        {
            await _usuarioServicio.AddAsync(entity);

        }
        [HttpPut("ActualizaTodoUsuario")]
        public async Task PostActualizaTodoUsuario(Usuario entity)
        {
            await _usuarioServicio.UpdateAsync(entity);

        }

        [HttpDelete("EliminaUsuario")]
        public async Task PostEliminarUsuario(Usuario entity)
        {
            await _usuarioServicio.DeleteAsync(entity.id_usuario);
        }





    }
}
