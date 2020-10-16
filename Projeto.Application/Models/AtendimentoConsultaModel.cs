using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Models
{
    public class AtendimentoConsultaModel
    {
        public string IdAtendimento { get; set; }
        public string DataAtendimento { get; set; }
        public string Local { get; set; }
        public string Observacoes { get; set; }

        public MedicoConsultaModel Medico { get; set; }
        public PacienteConsultaModel Paciente { get; set; }
    }
}
