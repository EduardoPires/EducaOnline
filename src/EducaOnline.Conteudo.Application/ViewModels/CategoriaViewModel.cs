﻿using System.ComponentModel.DataAnnotations;

namespace EducaOnline.Conteudo.Application.ViewModels
{
    public class CategoriaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Codigo { get; set; }
    }
}
