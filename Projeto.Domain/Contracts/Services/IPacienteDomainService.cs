using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Services
{
    public interface IPacienteDomainService : IBaseDomainService<Paciente>
    {
        List<Paciente> GetByNome(string nome);
        Paciente GetByCpf(string cpf);
        Paciente GetByEmail(string email);
    }
}
