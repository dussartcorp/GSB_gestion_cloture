﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_gestion_cloture
{
    /// <summary>
    /// Classe qui gére toutes les manipulations liée aux dates.
    /// </summary>
	public abstract class GestionDate
	{
		/// <summary>
        /// Retourne le mois precedent 
        /// </summary>
        /// <returns>Une chaine de caractere sous format de deux chiffres </returns>
		public static string getMoisPrecedent()
        {
			int moisPrecedent = DateTime.Now.Month - 1;
			if (moisPrecedent < 10)
            {
				string sortie = "0" + moisPrecedent.ToString();
				return sortie;
			}
			else
            {
				return (moisPrecedent).ToString();
            }
        }

        /// <summary>
        /// Surcharge de getMoisPrecedent(): Retourne le mois precedent 
        /// </summary>
        /// <param name="uneDate">La date dont on veut le mois précédent</param>
        /// <returns>Une chaine de caractere sous format de deux chiffres</returns>
        public static string getMoisPrecedent(DateTime uneDate)
        {
            int moisPrecedent = uneDate.Month - 1;
            if (moisPrecedent < 10)
            {
                string sortie = "0" + moisPrecedent.ToString();
                return sortie;
            }
            else
            {
                return (moisPrecedent).ToString();
            }
        }

        /// <summary>
        /// Retourne le mois suivant.
        /// </summary>
        /// <returns>Une chaine de caractere sous format de deux chiffres</returns>
        public static string getMoisSuivant()
        {
            var date = DateTime.Now.AddMonths(1);
            int moisSuivant = date.Month;
            if (moisSuivant < 10)
            {
                string sortie = "0" + moisSuivant.ToString();
                return sortie;
            }
            else
            {
                return (moisSuivant).ToString();
            }
        }

        /// <summary>
        /// Surcharge de getMoisSuivant(): Méthode qui retourne le mois suivant.
        /// </summary>
        /// <param name="uneDate">La date dont on veut le mois suivant</param>
        /// <returns>Une chaine de caractere sous format de deux chiffres</returns>
        public static string getMoisSuivant(DateTime uneDate)
        {
            uneDate = uneDate.AddMonths(1);
            int moisSuivant = uneDate.Month;
            if (moisSuivant < 10)
            {
                string sortie = "0" + moisSuivant.ToString();
                return sortie;
            }
            else
            {
                return (moisSuivant).ToString();
            }
        }

        /// <summary>
        /// Méthode qui dit si la date actuelle se situe entre un interval de deux jours
        /// </summary>
        /// <param name="jour1"></param>
        /// <param name="jour2"></param>
        /// <returns>Retourne true si la date actuelle se situe entre un interval de deux jours.</returns>
        public static bool entre(int jour1, int jour2)
        {
           return DateTime.Now.Day >= jour1 && DateTime.Now.Day < jour2;
        }

        /// <summary>
        /// Surcharge de entre(): Méthode qui dit si la date en parametre se situe entre un interval de deux jours
        /// </summary>
        /// <param name="jour1"></param>
        /// <param name="jour2"></param>
        /// <param name="uneDate"></param>
        /// <returns>Retourne true si la date actuelle se situe entre un interval de deux jours.</returns>
        public static bool entre(int jour1, int jour2, DateTime uneDate)
        {
            return uneDate.Day >= (jour1) && uneDate.Day < jour2;
        }
    }
}