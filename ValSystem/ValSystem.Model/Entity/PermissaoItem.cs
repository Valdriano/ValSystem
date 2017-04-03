﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValSystem.SQLite.Public.Attributes;

namespace ValSystem.Model.Entity
{
    public class PermissaoItem
    {
        [Autoincrement]
        public int Id { get; set; }
        [Required]
        public int IdRotina { get; set; }
        [Required]
        public int IdRotinaItem { get; set; }
        [Required]
        public int IdUsuario { get; set; }
        [Required]
        public bool Acesso { get; set; }
    }
}
