using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.Models
{
    class GameType
    {
        //Atributte/property
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Maker_Id { get; set; }

        //Relations
        public List<Game> Games { get; set; }
        public User User { get; set; }
    }
}
