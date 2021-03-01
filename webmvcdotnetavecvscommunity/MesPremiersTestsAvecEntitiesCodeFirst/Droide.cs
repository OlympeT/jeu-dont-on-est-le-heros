using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MesPremiersTestsAvecEntitiesCodeFirst
{
    [Table("Droide")]
    public class Droide
    {
        public int Id { get; set; }
        public string Matricule { get; set; }
    }
}
