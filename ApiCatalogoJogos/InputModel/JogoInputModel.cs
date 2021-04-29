﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do jogo deve conter entre 3 e 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome da produtora deve conter entre 3 e 100 caracteres")]
        public string Produtora { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O preco do jogo deve ser de no mínimo 1 real e no máximo 1000 reais")]
        public double Preco { get; set; }
    }
}