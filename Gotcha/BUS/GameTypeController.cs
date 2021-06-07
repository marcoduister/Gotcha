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
    class GameTypeController
    {
        private Gotcha_DBcontext Context = new Gotcha_DBcontext();

        internal bool DeleteGameType(Guid gameType_id)
        {
            try
            {
                GameType DeleteGameType = Context.GameTypes.Include(i => i.Games).First(f => f.Id == gameType_id);
                Context.Remove(DeleteGameType);
                Context.SaveChanges();

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        internal List<GameType> GetAllGameTypes()
        {
            try
            {
                List<GameType> List = Context.GameTypes.Include(i => i.User).ToList();

                return List;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        internal GameType GetGameTypeById(Guid gameType_id)
        {
            try
            {
                GameType GameType = Context.GameTypes.AsNoTracking().First(f => f.Id == gameType_id);

                return GameType;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        internal bool AddGameType(string Name, string description)
        {
            try
            {
                GameType gameType = new GameType()
                {
                    Id = Guid.NewGuid(),
                    Name = Name,
                    Description = description,
                    Maker_Id = new Guid(Properties.Settings.Default.UserId),
                };
                //Alert hier moet ingeloged gebruiker id nog bij
                Context.GameTypes.Add(gameType);
                Context.SaveChanges();
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        internal bool UpdateGameType(string Name, string Description, Guid gameType_id)
        {
            try
            {
                GameType gameType = new GameType()
                {
                    Id = gameType_id,
                    Name = Name,
                    Description = Description,
                    Maker_Id = new Guid(Properties.Settings.Default.UserId),
                };
                //Alert hier moet ingeloged gebruiker id nog bij
                Context.GameTypes.Update(gameType);
                Context.SaveChanges();
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
    }
}
