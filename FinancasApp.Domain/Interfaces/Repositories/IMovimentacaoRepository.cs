using FinancasApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interface para repositório de movimentação
    /// </summary>
    public interface IMovimentacaoRepository : IBaseRepository<Movimentacao>
    {
        /// <summary>
        /// Metodo para consultar uma lista de movimentações de acordo com:
        /// Data inicio de um periodo
        /// Data fim de um periodo
        /// Id do usuário
        /// </summary>
        List<Movimentacao> Get(DateTime dataMin, DateTime DataMax, Guid usuarioId);
    }
}
