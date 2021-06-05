using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.Models
{
    class Game
    {
        //Atributte/property
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EindTime { get; set; }
        public string Location { get; set; }
        public int? MaxPlayers { get; set; }
        public Guid? RandomWiner { get; set; }
        public Guid? BestKill { get; set; }
        public Boolean Archived { get; set; }
        public Guid Maker_Id { get; set; }
        public Guid? WordSet_Id { get; set; }
        public Guid? GameType_Id { get; set; }
        public Guid? RuleSet_Id { get; set; }

        //Relations
        public virtual RuleSet RuleSet { get; set; }
        public virtual User User { get; set; }
        public virtual GameType GameType { get; set; }
        public virtual WordSet WordSet { get; set; }
        public List<Contract> Contracts { get; set; }


    }
}
