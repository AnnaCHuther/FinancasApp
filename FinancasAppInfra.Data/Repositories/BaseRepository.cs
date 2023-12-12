using FinancasApp.Domain.Interfaces.Repositories;
using FinancasApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Infra.Data.Repositories
{
    /// <summary>
    /// Classe genérica para repositório de banco de dados
    /// </summary>
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        /// <summary>
        /// Inserir um registro em uma tabela no banco de dados
        /// </summary>

        public void Add(T entity)
        {
            using (var dataContex = new DataContext())
            { 
                dataContex.Add(entity);
                dataContex.SaveChanges();   
            }
        }
        /// <summary>
        /// Atualizar um registro em uma tabela do banco de dados
        /// </summary>

        public void Update(T entity)
        {
            using (var dataContex = new DataContext())
            {
                dataContex.Update(entity);
                dataContex.SaveChanges();
            }
        }
        /// <summary>
        /// Excluir um registro em uma tabela do banco de dados
        /// </summary>
        public void Delete(T entity)
        {
            using (var dataContex = new DataContext())
            {
                dataContex.Remove(entity);
                dataContex.SaveChanges();
            }
        }

        /// <summary>
        /// Consultar todos os registro em uma tabela do banco de dados
        /// </summary>
        public List<T> GetAll()
        {
            using (var dataContex = new DataContext())
            {
                return dataContex.Set<T>().ToList();                
            }
        }
        /// <summary>
        /// Consultar 1 registro em uma tabela do banco de dados através do ID
        /// </summary>
        public T? GetById(Guid id)
        {
            using (var dataContex = new DataContext())
            {
                return dataContex.Set<T>().Find(id);
            }
        }
    }
}




