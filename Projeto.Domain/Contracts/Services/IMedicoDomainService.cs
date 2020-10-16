using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Services
{
    public interface IMedicoDomainService : IBaseDomainService<Medico>
    {
        List<Medico> GetByNome(string nome);
        List<Medico> GetByEspecializacao(string especializacao);
    }
}
