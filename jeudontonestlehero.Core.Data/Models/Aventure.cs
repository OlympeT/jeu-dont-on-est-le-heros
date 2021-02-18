﻿using System;
namespace jeudontonestlehero.Core.Data
{
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
        public string Titre { get; set; }
        #endregion

        public Aventure()
        {
        }
    }
}
