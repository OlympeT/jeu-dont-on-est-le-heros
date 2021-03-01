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
        public int Numero { get; set; }
        public string Titre { get; set; }
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
