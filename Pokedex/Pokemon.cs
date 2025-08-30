using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class Pokemon
    {

        #region Properties

        public int pokemonId { get; set; }
        public string pokemonName { get; set; }
        public List<string> pokemonType { get; set; }

        #endregion

        #region Constructor
        public Pokemon() //empty constructor lol
        {
            pokemonId = 1;
            pokemonName = string.Empty;
            pokemonType = new List<string>();
        }

        public Pokemon(int pokeid) //constructor with ID
        {
            pokemonId = pokeid;
            pokemonName = string.Empty;
            pokemonType = new List<string>();
        }
        #endregion

        #region Methods

        //get hunts targeting that pokemon
        public List<int> getPokemonHunt()
        {
            List<int> hunts = new List<int>();

            return hunts;
        }


        #endregion
    
    }
}
