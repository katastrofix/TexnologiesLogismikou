using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.Model
{
    public class ProgrammingLanguage
    {
        public Guid ProgrammingLanguageID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
