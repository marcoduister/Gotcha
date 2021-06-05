using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.Models
{
    class Contract
    {
        //Atributte/property

        public Guid Id { get; set; }
        public Guid Game_Id { get; set; }
        public Guid User_Id { get; set; }
        public Guid? Word_Id { get; set; }
        public DateTime? EliminatedTime { get; set; }
        public int Eliminations { get; set; }

        //Relations
        public Game Game { get; set; }
        public User User { get; set; }
    }
}
