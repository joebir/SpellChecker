﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellchecker.ViewModels
{
    public class CreateSpellbookModel
    {
        [Required]
        public string SpellbookName { get; set; }
    }
}