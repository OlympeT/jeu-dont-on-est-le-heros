using System;
using System.ComponentModel.DataAnnotations;

namespace DecouverteValidateurs.Models
{
    public class Jedi
    {
        [Required]
        public string Name { get; set; }

        [Range(0,300)]
        public int Size { get; set; }
    }
}
