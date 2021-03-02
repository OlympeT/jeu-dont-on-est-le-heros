using System;
using System.ComponentModel.DataAnnotations;

namespace DecouverteValidateurs.Models
{
    public class Jedi
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le nom doit etre renseigné")]
        public string Name { get; set; }

        [Range(0,300, ErrorMessage = "La taille est entre 1 et 300 cm")]
        public int Size { get; set; }
    }
}
