using Gotcha.DAL;
using Gotcha.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.BUS
{
    class GameController
    {
        private Gotcha_DBcontext Context = new Gotcha_DBcontext();

        public List<Game> OverView()
        {
            
            return Context.Games.Include(e=>e.User).Where(g => g.Maker_Id == new Guid("6b6ac9b4-ebec-4098-bfd7-af1fa0f79b6c")).ToList(); ;
        }

        public void Read()
        {

        }
        public void Create()
        {

        }
        public void Edit(Game Game)
        {

        }
        public void Delete(Guid Game_Id)
        {

        }
    }
}
