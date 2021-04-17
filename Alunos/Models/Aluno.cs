using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alunos.Models
{
    public class Aluno
    {
        [key]
        public long? AlunoID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Display(Name="Endereço")]
        public string Endereço { get; set; }
        [EmailAddress(ErrorMessage ="Email invalido.")]
        [Display(Name ="Email")]
        public string Email { get; set; }

        public string Telefone { get; set; }
    }
}
