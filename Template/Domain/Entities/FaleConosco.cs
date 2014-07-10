using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FaleConosco : EntitieBase
    {
        [Key]
        public int FaleConoscoId { get; set; }

        public ApplicationUser User { get; set; }

        public FaleConoscoAssunto Assunto { get; set; }

        public string Titulo { get; set; }

        public string Texto { get; set; }

        

    }
}
