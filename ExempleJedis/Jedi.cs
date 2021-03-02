using System;

namespace ExempleJedis
{
    public class Jedi
    {
        public int PointDeVie { get; set; }

        public void Attaquer ( Droide droide)
        {
            if (droide !=null )
            {
                droide.PointDeVie -= 50;
            }
            throw new NotImplementedException();
        }
    }
}
