using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.Model
{
    public class Project
    {
        public Guid ProjectID { get; set; }

        public Student Assignee { get; set; }

        public Professor SupervisingProfessor { get; set; }

        [Required]
        public string Title { get; set; }

        public ProgrammingLanguage Language { get; set; }

        public TechnologyStack Technology { get; set; }

    }
}
