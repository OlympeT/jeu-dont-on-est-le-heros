using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace jeudontonestlehero.Core.Data.Models
{
    [Table("Paragraphe")]
    public class Paragraphe
    {
        #region Proprietes
        [Key]
        public int Id { get; set; }

        [Range(1, 99999999, ErrorMessage = "Le titre doit être renseigné.")]
        public int Numero { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre doit être renseigné.")]
        public string Titre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre doit être renseigné.")]
        public string Description { get; set; }
        /// <summary>
        /// Question de paragraphe
        /// </summary>
        public Question MaQuestion { get; set; }
        #endregion
        public Paragraphe()
        {
        }
    }
}
