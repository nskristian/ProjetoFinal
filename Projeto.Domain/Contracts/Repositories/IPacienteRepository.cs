using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IPacienteRepository : IBaseRepository<Paciente>
    {
        List<Paciente> GetByNome(string nome);
        Paciente GetByCpf(string cpf);
        Paciente GetByEmail(string email);
    }
}
