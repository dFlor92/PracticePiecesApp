using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWAPITest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CharacterInfo();
        }

        public void CharacterInfo()
        {
            RestClient client = new RestClient("https://eu.api.battle.net/");
            RestRequest request = new RestRequest("wow/guild/Draenor/Pieces?fields=members&locale=en_GB&apikey=jypv5advxjdchn257gup5nqesf777gf9", Method.GET);

            IRestResponse<Guild> response = client.Execute<Guild>(request);
            Guild g = response.Data;

            List<Character> characters = new List<Character>();
            foreach (Member m in g.members)
            {
                characters.Add(m.character);
            }

            dataGridView1.DataSource = characters;
         


            //dataGridView2.DataSource = g.members.;
            // textBox1.Text = response.Data.GuildName;

        }


    }
}
