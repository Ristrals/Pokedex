using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Pokedex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI Event handlers

        private int testNumber { get; set; } //test number for buttons
       

        private void button1_Click(object sender, EventArgs e)
        {
            response.Clear();
            testNumber = 75;

            RestClient restClient = new RestClient();
            restClient.endPoint = $"https://pokeapi.co/api/v2/pokemon-form/{testNumber}";

            response.Text = "Rest Client Created";

            string strResponse = restClient.MakeRequest();

            response.Text = $"{strResponse}";

            pokemonShow.Load($"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/{testNumber}.png");


            /*JObject pokemon = (JObject)JObject.(strResponse)["types"][0]["type"];
            string order = (string)pokemon["name"];
            response.Text = $"{order}";*/

            JObject pokemon = (JObject)JObject.Parse(strResponse);
            string type1 = (string)pokemon.SelectToken("types[0].type.name");
            string type2 = (string)pokemon.SelectToken("types[1].type.name");
            response.Text = $"{type1} {type2}";
        }



        #endregion

    }
}
