using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FichaAcademia.Dominio.Models
{
    public class Exercicio
    {
        public int ExercicioId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [StringLength(50, ErrorMessage = "Use Menos caracteres.")]
        public string Nome { get; set; }

        public int CategoriaExercicioId { get; set; }
        public CategoriaExercicio CategoriaExercicio { get; set; }

        public ICollection<ListaExercicio> ListaExercicios { get; set; }


    }
}
