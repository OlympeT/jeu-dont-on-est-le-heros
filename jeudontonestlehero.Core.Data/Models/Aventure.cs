using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jeudontonestlehero.Core.Data.Models
{
    [Table("Aventure")]
    public class Aventure
    {
        #region Proprietes
        /// <summary>
        /// id de chaque aventure
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// titre de chaque aventure
        /// </summary>
        [Required(AllowEmptyStrings = true, ErrorMessage = "Titre est obligatoire")]
        public string Titre { get; set; }
        #endregion
    }
}
