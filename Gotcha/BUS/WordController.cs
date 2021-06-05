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
    class WordController
    {
        private Gotcha_DBcontext Context = new Gotcha_DBcontext();

        public WordController()
        {
            
        }

        public List<WordSet> GetAllWordSets()
        {
            try
            {
                List<WordSet> List = Context.WordSets.Include(i => i.User).ToList();

                return List;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
        public List<Word> GetAllWords()
        {
            try
            {
                List<Word> List = Context.Words.Include(i => i.User).ToList();

                return List;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        internal bool DeleteWord(Guid word_id)
        {
            try
            {
                Word DeleteWord = Context.Words.Include(i=>i.WordWordset).First(f => f.Id == word_id);
                Context.Remove(DeleteWord);
                Context.SaveChanges();

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        internal bool DeleteWordSet(Guid wordSet_id)
        {
            try
            {
                WordSet DeletewordSet = Context.WordSets.Include(i => i.WordWordset).First(f => f.Id == wordSet_id);
                Context.Remove(DeletewordSet);
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
