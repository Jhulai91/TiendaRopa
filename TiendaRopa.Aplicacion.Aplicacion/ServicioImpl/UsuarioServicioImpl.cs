using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaRopa.Dominio.Modelo.Abstracciones;
using TiendaRopa.Infraestructura.AccesoDatos;
using TiendaRopa.Infraestructura.AccesoDatos.Repositorio;
using TiendaRopa.Aplicacion.Aplicacion.Servicio;

namespace TiendaRopa.Aplicacion.Aplicacion.ServicioImpl
{
   public class UsuarioServicioImpl : IUsuarioServicio
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly BD_ModaEcContext _dbcontext;

        public UsuarioServicioImpl(BD_ModaEcContext context)
        {
            _dbcontext = context;
            _usuarioRepositorio = new UsuarioRepositorioImpl(context);

        }

        public async Task AddAsync(Usuario entity)
        {
            await _usuarioRepositorio.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _usuarioRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            return await _usuarioRepositorio.GetAllAsync();
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            return await _usuarioRepositorio.GetByIdAsync(id);
        }

        public IEnumerable<Usuario> ListarUsuarioPorEstado(string estado)
        {
            return _usuarioRepositorio.ListarUsuarioPorEstado(estado);
        }

        public IEnumerable<Usuario> ListarUsuarioPorLetras(string letras)
        {
            return _usuarioRepositorio.ListarUsuarioPorLetras(letras);
        }

        public IEnumerable<Usuario> ListarUsuarioPorUser(string user)
        {
            return _usuarioRepositorio.ListarUsuarioPorUser(user);
        }

        public async Task UpdateAsync(Usuario entity)
        {
            await _usuarioRepositorio.UpdateAsync(entity);
        }
    }
}
