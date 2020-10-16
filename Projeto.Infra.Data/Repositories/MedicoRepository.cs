using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class MedicoRepository : BaseRepository<Medico>, IMedicoRepository
    {
        private readonly DataContext dataContext;

        public MedicoRepository(DataContext dataContext)
            : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<Medico> GetByNome(string nome)
        {
            return dataContext.Medico.Where(m => m.Nome.Contains(nome)).ToList();
        }

        public List<Medico> GetByEspecializacao(string especializacao)
        {
            return dataContext.Medico.Where(m => m.Especializacao.Contains(especializacao)).ToList();
        }

        public Medico GetByCrm(string crm)
        {
            return dataContext.Medico.FirstOrDefault(m => m.Crm.Equals(crm));
        }
    }
}
