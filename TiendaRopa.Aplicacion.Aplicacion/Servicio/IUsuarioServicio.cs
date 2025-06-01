using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TiendaRopa.Infraestructura.AccesoDatos;

namespace TiendaRopa.Aplicacion.Aplicacion.Servicio
{
    [ServiceContract]
    public interface IUsuarioServicio
    {

        [OperationContract]
        Task<Usuario> GetByIdAsync(int id);//buscar por id
        [OperationContract]
        Task<IEnumerable<Usuario>> GetAllAsync();//listar todo
        [OperationContract]
        Task AddAsync(Usuario entity);//insertar
        [OperationContract]
        Task UpdateAsync(Usuario entity);//actualizar
        [OperationContract]
        Task DeleteAsync(int id);//eliminar por id
        [OperationContract]
        IEnumerable<Usuario> ListarUsuarioPorUser(string user);
        [OperationContract]
        IEnumerable<Usuario> ListarUsuarioPorEstado(string estado);
        [OperationContract]
        IEnumerable<Usuario> ListarUsuarioPorLetras(string letras);
    }
}
