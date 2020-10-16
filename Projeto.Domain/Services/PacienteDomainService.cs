using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class PacienteDomainService : BaseDomainService<Paciente>, IPacienteDomainService
    {
        private readonly IPacienteRepository pacienteRepository;

        public PacienteDomainService(IPacienteRepository pacienteRepository)
            : base(pacienteRepository)
        {
            this.pacienteRepository = pacienteRepository;
        }

        public override void Insert(Paciente obj)
        {
            if (pacienteRepository.GetByCpf(obj.Cpf) == null)
            {
                pacienteRepository.Insert(obj);
            }
            else
            {
                throw new Exception("Erro, o CPF informado já encontra-se cadastrado.");
            }
        }

        public List<Paciente> GetByNome(string nome)
        {
            return pacienteRepository.GetByNome(nome);
        }

        public Paciente GetByCpf(string cpf)
        {
            return pacienteRepository.GetByCpf(cpf);
        }

        public Paciente GetByEmail(string email)
        {
            return pacienteRepository.GetByEmail(email);
        }
    }
}
