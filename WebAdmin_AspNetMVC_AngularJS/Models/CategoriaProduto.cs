﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAdmin.Models
{
    [Table("CategoriaProdutos")]
    public class CategoriaProduto
    {
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}