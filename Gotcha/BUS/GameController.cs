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

        public List<Game> GetAllGames()
        {
            return Context.Games.Where(g => g.Maker_Id == new Guid("6b6ac9b4-ebec-4098-bfd7-af1fa0f79b6c")).Include(e => e.User).ToList();
        }
        public List<User> GetUsers()
        {
            return Context.Users.Where(g => g.Id != new Guid("6b6ac9b4-ebec-4098-bfd7-af1fa0f79b6c")).ToList();
        }
        public Game GetGameById(Guid Game_Id)
        {
            return Context.Games.Include(e => e.Contracts).Where(g => g.Id == Game_Id).First();
        }

        internal void GetcontractsByGameId(Guid game_Id)
        {
            
        }
        internal (List<WordSet>,List<GameType>,List<RuleSet>) GetGameComboLists()
        {
            try
            {
                List<GameType> gameTypeList = Context.GameTypes.ToList();
                List<WordSet> wordSetsList = Context.WordSets.ToList();
                List<RuleSet> ruleSetsList = Context.RuleSets.ToList();

                return (wordSetsList, gameTypeList, ruleSetsList);
            }
            catch (Exception Ex)
            {
                return ( null, null, null);
            }
        }

        public void Read()
        {
            
        }
        public bool AddContractUser(Guid User_Id, Guid Game_Id)
        {
            try
            {
                Game game = GetGameById(Game_Id);
                Contract contract = new Contract();
                if (game.WordSet_Id != null)
                {
                    List<WordWordset> WordenList = Context.WordWordsets.Include(i =>i.Word).Where(w => w.WordSet_Id == game.WordSet_Id).ToList();
                    // Allert - hier moet ngo naar gekeken worden hij maakt nu een nieuwe guid aan maar er moet gekeken worden dat die een random wordt kiest van de worden set
                    contract.Word_Id = Guid.NewGuid();
                }

                contract.Game_Id = Game_Id;
                contract.User_Id = User_Id;
                contract.Eliminations = 0;
                Context.Contracts.Add(contract);
                Context.SaveChanges();

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public void Edit(Game Game)
        {

        }

        internal bool AddGame(Game game)
        {

            try
            {
                game.Id = Guid.NewGuid();
                game.Maker_Id = new Guid("6b6ac9b4-ebec-4098-bfd7-af1fa0f79b6c");
                Context.Games.Add(game);
                Context.SaveChanges();

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }

        }
        public bool Archiving(Guid Game_Id)
        {
            try
            {
                Game ArchivingGame = GetGameById(Game_Id);
                ArchivingGame.Archived = true;
                Context.Games.Update(ArchivingGame);
                Context.SaveChanges();

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        public bool StartGame(Guid Game_Id)
        {
            try
            {
                Game StartGame = Context.Games.First(e => e.Id == Game_Id);
                StartGame.StartTime = DateTime.Now;
                Context.Update(StartGame);
                Context.SaveChanges();

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public bool Delete(Guid Game_Id)
        {
            try
            {
                Game DeleteGame = Context.Games.Include(i => i.Contracts)
                    .First(e => e.Archived == false && e.StartTime == null && e.Id == Game_Id);
                Context.Remove(DeleteGame);
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
