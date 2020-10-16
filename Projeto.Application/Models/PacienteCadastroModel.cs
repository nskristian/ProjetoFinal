using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models
{
    public class PacienteCadastroModel
    {
        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do paciente.")]
        public string Nome { get; set; }

        [RegularExpression(@"/^\d{3}\.\d{3}\.\d{3}\-\d{2}$/", ErrorMessage = "Por favor, informe um cpf válido.")]
        [Required(ErrorMessage = "Por favor, informe o cpf do paciente.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de nascimento do paciente.")]
        public string DataNascimento { get; set; }

        [Required(ErrorMessage = "Por favor, informe o telefone do paciente.")]
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "Por favor, informe um email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email do paciente.")]
        public string Email { get; set; }
    }
}
