﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.Model
{
    public class TechnologyStack
    {
        public Guid TechnologyStackID { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
