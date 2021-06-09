﻿using Gotcha.DAL;
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
            return Context.Games.AsNoTracking().Where(g => g.Maker_Id == new Guid(Properties.Settings.Default.UserId)).Include(e => e.User).ToList();
        }
        public List<User> GetUsers()
        {
            return Context.Users.AsNoTracking().Where(g => g.Id != new Guid(Properties.Settings.Default.UserId)).ToList();
        }
        public Game GetGameById(Guid Game_Id)
        {
            return Context.Games.AsNoTracking().Include(e => e.Contracts).ThenInclude(th =>th.User).AsNoTracking().Where(g => g.Id == Game_Id).First();
        }

        internal List<Contract> GetcontractsByGameId(Guid Game_Id)
        {
            return Context.Contracts.AsNoTracking().Where(g => g.Game_Id == Game_Id).ToList();
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

        public bool Edit(Game Game)
        {
            try
            {
                Game.Maker_Id = new Guid(Properties.Settings.Default.UserId);
                Context.Games.Update(Game);
                Context.SaveChanges();

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        internal bool AddGame(Game game)
        {

            try
            {
                game.Id = Guid.NewGuid();
                game.Maker_Id = new Guid(Properties.Settings.Default.UserId);
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
                ArchivingGame.EindTime = DateTime.Now;
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

        internal bool DeleteContract(Guid user_id, Guid game_Id)
        {
            try
            {
                Contract DeleteContract = Context.Contracts.First(e => e.Game_Id == game_Id && e.User_Id == user_id);
                Context.Remove(DeleteContract);
                Context.SaveChanges();

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        internal bool KillContract(Guid user_id, Guid Game_Id)
        {
            try
            {
                List<Contract> contracts = GetcontractsByGameId(Game_Id);

                int KiledUserIndex = contracts.FindIndex(fi => fi.User_Id == user_id);
                int KillerUserIndex = 0;
                
                foreach (var Contract in contracts)
                {
                    List<Contract> NotElimineted = contracts.Where(w => w.EliminatedTime == null).ToList();
                    
                    if (KiledUserIndex == 0)
                    {
                        contracts[KiledUserIndex].EliminatedTime = DateTime.Now;
                        if (NotElimineted.FindIndex(fi => fi.User_Id == user_id) == 0)
                        {
                            if (NotElimineted.Count() != 1)
                                KillerUserIndex = NotElimineted.Count() - 1;
                        }

                        int index = contracts.FindIndex(i =>i.User_Id == NotElimineted[KillerUserIndex].User_Id);
                        contracts[index].Eliminations += 1;
                        break;
                    }
                    else
                    {
                        contracts[KiledUserIndex].EliminatedTime = DateTime.Now;

                        int index = contracts.FindIndex(i => i.User_Id == NotElimineted[KillerUserIndex].User_Id);
                        contracts[index].Eliminations += 1;
                        break;
                    }
                }
                Context.UpdateRange(contracts);
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
