using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace jeudontonestlehero.Core.Data.Models
{
    [Table("Paragraphe")]
    public class Paragraphe
    {
        #region Proprietes
        /// <summary>
        /// Id venant de la base
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Numéro à afficher pour le jeu
        /// </summary>
        [Range(1, 99999999, ErrorMessage = "Le titre doit être renseigné.")]
        public int Numero { get; set; }

        /// <summary>
        /// C'est le titre du paragraphe
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre doit être renseigné.")]
        public string Titre { get; set; }

        /// <summary>
        /// Description du paragraphe
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre doit être renseigné.")]
        public string Description { get; set; }

        /// <summary>
        /// Question de paragraphe
        /// </summary>
        public Question MaQuestion { get; set; }

        /// <summary>
        /// Liste de reponse
        /// </summary>
        public IEnumerable<Reponse> Reponses { get; set; }

        /// <summary>
        /// Indique si c'est le parapgraphe de démarrage
        /// </summary>
        public Boolean EstInitial { get; set; }
        #endregion

    }
}
