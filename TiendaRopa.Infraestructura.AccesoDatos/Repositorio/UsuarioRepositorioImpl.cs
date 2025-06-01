using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaRopa.Dominio.Modelo.Abstracciones;

namespace TiendaRopa.Infraestructura.AccesoDatos.Repositorio
{
    public class UsuarioRepositorioImpl : RepositorioImpl<Usuario>, IUsuarioRepositorio
    {

        private readonly BD_ModaEcContext _context;
        public UsuarioRepositorioImpl(BD_ModaEcContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> ListarUsuarioPorEstado(string estado)
        {
            try
            {
                var consultaestado = from usuariosestado in _context.Usuario

                                     where usuariosestado.estado == estado
                                     orderby usuariosestado.id_usuario descending
                                     select usuariosestado;

                return consultaestado; //ejecutar
            }
            catch (Exception ex)
            {
                throw new Exception("Error usuario por nick:" + ex.Message);

            }
        }

        public IEnumerable<Usuario> ListarUsuarioPorLetras(string letras)
        {
            try
            {
                var consultapassletras = from usuariosletras in _context.Usuario

                                         where usuariosletras.contraseña.Contains(letras)

                                         select usuariosletras;

                return consultapassletras; //ejecutar
            }
            catch (Exception ex)
            {
                throw new Exception("Error usuario por nick:" + ex.Message);

            }
        }

        public IEnumerable<Usuario> ListarUsuarioPorUser(string user)
        {
            try
            {
                var consulta = from usuariosactivo in _context.Usuario

                               where usuariosactivo.nombre == user
                               select usuariosactivo;

                return consulta; //ejecutar
            }
            catch (Exception ex)
            {
                throw new Exception("Error usuario por nick:" + ex.Message);

            }
        }
    }
}
