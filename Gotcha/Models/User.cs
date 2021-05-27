using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gotcha.Models
{
    class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public enum Rol { Player,Gamemaster,Admin }
        public bool UserActive { get; set; }
        //public Image ProfileImage { get; set; }
        public Guid Maker_Id { get; set; }
        public User user { get; set; }
        public List<Word> Word { get; set; }
        public List<WordSet> WordSets { get; set; }
        public List<RuleSet> RuleSets { get; set; }
        public List<Rule> Rules { get; set; }
        public List<GameType> GameTypes { get; set; }
        public List<Game> Games { get; set; }

    }
}
