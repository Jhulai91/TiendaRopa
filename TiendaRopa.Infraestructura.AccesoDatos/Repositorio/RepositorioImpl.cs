using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaRopa.Dominio.Modelo.Abstracciones;

namespace TiendaRopa.Infraestructura.AccesoDatos.Repositorio
{
    public class RepositorioImpl<T> : IRepositorio<T> where T : class
    {
        private readonly BD_ModaEcContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositorioImpl(BD_ModaEcContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception("Error: clase genérica Insertar" + ex.Message);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var resultado = await GetByIdAsync(id);
                _dbSet.Remove(resultado);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception("Error: clase genérica Eliminar" + ex.Message);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();


            }
            catch (Exception ex)
            {
                throw new Exception("Error: clase genérica Listar" + ex.Message);
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);


            }
            catch (Exception ex)
            {
                throw new Exception("Error: clase genérica Buscar por id" + ex.Message);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception("Error: clase genérica Actualizar" + ex.Message);
            }
        }
    }
}
