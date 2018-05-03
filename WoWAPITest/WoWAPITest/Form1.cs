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
        }

        public void CharacterInfo()
        {
            
            RestClient client = new RestClient("https://eu.api.battle.net/");
            RestRequest request = new RestRequest("wow/guild/{Realm}/{Guild}?fields=members&locale=en_GB&apikey=jypv5advxjdchn257gup5nqesf777gf9", Method.GET);
            request.AddUrlSegment("Realm", textBox1.Text);
            request.AddUrlSegment("Guild", textBox2.Text);

            IRestResponse<Guild> response = client.Execute<Guild>(request);    

            List<Character> characters = new List<Character>();
            foreach (Member m in response.Data.members)
            {
                characters.Add(m.character);
            }

            dataGridView1.DataSource = characters;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CharacterInfo();
        }
    }
}
