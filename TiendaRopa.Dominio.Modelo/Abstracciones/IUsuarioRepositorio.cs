using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaRopa.Infraestructura.AccesoDatos;

namespace TiendaRopa.Dominio.Modelo.Abstracciones
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        IEnumerable<Usuario> ListarUsuarioPorUser(string user);

        IEnumerable<Usuario> ListarUsuarioPorEstado(string estado);

        IEnumerable<Usuario> ListarUsuarioPorLetras(string letras);
    }
}
