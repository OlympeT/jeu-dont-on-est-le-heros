using System;
using System.Collections.Generic;

namespace jeudontonestlehero.Core.Data.Models
{
    public class Question
    {
        #region Proprietes
        public int Id { get; set; }
        public string Titre { get; set; }
        /// <summary>
        /// Liste des reponses
        /// </summary>
        public List<Reponse> MesReponses { get; set; }
        #endregion
        public Question()
        {
        }
    }
}
