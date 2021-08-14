using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace domain.Entities
{
    public class User : Entity
    {
        [Required(ErrorMessage = "Nome do usuário obrigatório.")]
        public string Username { get; set; }

        public IList<MS> MSs { get; set; }
    }
}