using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FichaAcademia.Dominio.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [StringLength(100, ErrorMessage = "Use Menos caracteres.")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Range(14, 100, ErrorMessage = "Idade Inválida.")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Range(14, 150, ErrorMessage = "Peso Inválido.")]
        public double Peso { get; set; }

        public int ObjetivoId { get; set; }
        public Objetivo Objetivo { get; set; }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Range(1, 7, ErrorMessage = "Frequência Inválida.")]
        public int FrequenciaSemanal { get; set; }

        public ICollection<Ficha> Fichas { get; set; }

    }
}
