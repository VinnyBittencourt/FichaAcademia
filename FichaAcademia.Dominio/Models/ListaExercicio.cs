using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FichaAcademia.Dominio.Models
{
    public class ListaExercicio
    {
        public int ListaExercicioId { get; set; }

        public int ExercicioId { get; set; }
        public Exercicio Exercicio { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Range(1, 10, ErrorMessage = "Frequência Inválida.")]
        public int Frequencia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Range(1, 100, ErrorMessage = "Número Inválido.")]
        public int Repeticoes { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Range(1, 200, ErrorMessage = "Número Inválida.")]
        public int Carga { get; set; }

        public int FichaId { get; set; }
        public Ficha Ficha { get; set; }
    }
}
