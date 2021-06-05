using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gotcha.Models.Enums;

namespace Gotcha.Models
{
    class User
    {
        //Atributte/property
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public Rolen Rol { get; set; }
        public bool UserActive { get; set; }
        public byte[] ProfileImage { get; set; }

        //Relations
        public List<Word> Word { get; set; }
        public List<WordSet> WordSets { get; set; }
        public List<RuleSet> RuleSets { get; set; }
        public List<Rule> Rules { get; set; }
        public List<Contract> Contracts { get; set; }
        public List<GameType> GameTypes { get; set; }
        public List<Game> Games { get; set; }

    }
}
