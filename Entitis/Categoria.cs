﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Entitis
{
	[Table("Categorias")]
	public class Categoria
	{

		[Key]
		public int CategoriaId { get; set; }

        [Required]
		[MaxLength(80)]
		public string Nome { get; set; }

        [Required]
		[MaxLength(300)]
		public string ImagemUrl { get; set; }

		public ICollection<Produto> Produtos { get; set; }

    }
}

