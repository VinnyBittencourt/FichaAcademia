using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace FichaAcademia.Dominio.Models
{
    public class CategoriaExercicio
    {
        public int CategoriaExercicioId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [StringLength(50, ErrorMessage = "Use Menos caracteres.")]
        [Remote("CategoriaExiste", "CategoriasExercicios", AdditionalFields = "CategoriaExercicioId")] 
        public string Nome { get; set; }

        public ICollection<Exercicio> Exercicio { get; set; }
    }
}

//install-package Microsoft.AspNetCore.Mvc para poder usar a authentication remota