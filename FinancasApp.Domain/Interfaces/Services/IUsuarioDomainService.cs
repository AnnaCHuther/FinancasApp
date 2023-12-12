using FinancasApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Domain.Interfaces.Services
{
    /// <summary>
    /// Interface de serviços de domínio para entidade Usuário
    /// </summary>
    public interface IUsuarioDomainService
    {
        /// <summary>
        /// Criar um usuário no sistema
        /// </summary>
        /// <param name="usuario"></param>
        void CriarUsuario(Usuario usuario);

        /// <summary>
        /// Pbter um usuário valido no sistema
        /// </summary>
        Usuario Obter(string email, string senha);
    }
}
