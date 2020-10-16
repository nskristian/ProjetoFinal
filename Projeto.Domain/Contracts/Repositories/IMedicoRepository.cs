using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IMedicoRepository : IBaseRepository<Medico>
    {
        List<Medico> GetByNome(string nome);
        List<Medico> GetByEspecializacao(string especializacao);
        Medico GetByCrm(string crm);
    }
}
