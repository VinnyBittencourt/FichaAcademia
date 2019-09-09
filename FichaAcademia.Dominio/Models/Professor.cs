using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FichaAcademia.Dominio.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [StringLength(50, ErrorMessage = "Use Menos caracteres.")]
        public string Nome { get; set; }

        public string Foto { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [StringLength(10, ErrorMessage = "Use Menos caracteres.")]
        public string Turno { get; set; }

        public ICollection<Aluno> Alunos { get; set; }
    }
}
