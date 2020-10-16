using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models
{
    public class AtendimentoCadastroModel
    {
        [Required(ErrorMessage = "Por favor, informe a data do atendimento.")]
        public string DataAtendimento { get; set; }

        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o local do atendimento.")]
        public string Local { get; set; }

        [MaxLength(300, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe as observações do atendimento.")]
        public string Observacoes { get; set; }

        [RegularExpression("^[0-9]{1,9}$", ErrorMessage = "Por favor, informe um id do médico válido.")]
        [Required(ErrorMessage = "Por favor, informe o id do médico.")]
        public string IdMedico { get; set; }

        [RegularExpression("^[0-9]{1,9}$", ErrorMessage = "Por favor, informe um id do paciente válido.")]
        [Required(ErrorMessage = "Por favor, informe o id do paciente.")]
        public string IdPaciente { get; set; }
    }
}
