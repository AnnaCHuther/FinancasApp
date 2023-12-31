﻿using FinancasApp.Domain.Entities;
using FinancasApp.Domain.Interfaces.Repositories;
using FinancasApp.Infra.Data.Repositories;
using FinancasApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Infra.Data.Repositories
{
    /// <summary>
    /// Repositório de dados para entidade usuário   
    /// </summary>
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public Usuario? Get(string email)
        {
            using (var dataContex = new DataContext())
            {
                return dataContex.Set<Usuario>()
                  .Where(u => u.Email.Equals(email))
                  .FirstOrDefault();
            } 
        }

        public Usuario? Get(string email, string senha)
        {
            using (var dataContex = new DataContext())
            {
                return dataContex.Set<Usuario>()
                  .Where(u => u.Email.Equals(email) && u.Senha.Equals(senha))
                  .FirstOrDefault();
            }
        }
    }
}
