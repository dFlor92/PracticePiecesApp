using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWAPITest
{
   public class Guild
    {
        public List<Member> members { get; set; }
        [DeserializeAs (Name = "Name")]
        public String GuildName { get; set; }
    }
}
