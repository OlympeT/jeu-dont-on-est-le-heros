using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jeudontonestlehero.Core.Data.Models
{
    [Table("Reponse")]
    public class Reponse
    {
        #region Proprietes
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int QuestionId { get; set; }
        #endregion
        public Reponse()
        {
        }
    }
}
