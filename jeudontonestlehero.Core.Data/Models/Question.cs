using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace jeudontonestlehero.Core.Data.Models
{
    [Table("Question")]
    public class Question
    {
        #region Proprietes
        [Key]
        public int Id { get; set; }
        public string Titre { get; set; }
        /// <summary>
        /// Liste des reponses
        /// </summary>
        public List<Reponse> MesReponses { get; set; }

        public int ParagrapheId { get; set; }

        #endregion
        public Question()
        {
        }
    }
}
