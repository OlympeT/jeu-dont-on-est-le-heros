using System;
namespace jeudontonestlehero.Core.Data.Models
{
    public class Paragraphe
    {
        #region Proprietes
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
