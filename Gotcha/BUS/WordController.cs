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
        internal string GetWordById(Guid word_id)
        {
            try
            {
                string word = Context.Words.AsNoTracking().First(f => f.Id == word_id).Content;

                return word;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        internal WordSet GetWordSetById(Guid wordSet_Id)
        {
            try
            {
                WordSet wordSet = Context.WordSets.AsNoTracking().Include(i => i.WordWordset).ThenInclude(th =>th.Word).AsNoTracking().First(f => f.Id == wordSet_Id);

                return wordSet;
            }
            catch (Exception Ex)
            {
                return null;
            }
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

        internal bool UpdateWord(string word, Guid word_id)
        {
            try
            {
                Word wordz = new Word()
                {
                    Id = word_id,
                    Content = word,
                    Maker_Id = new Guid(Properties.Settings.Default.UserId),
                };
                Context.Words.Update(wordz);
                Context.SaveChanges();
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        internal bool UpdateWordSet(string Name,Guid wordSet_id)
        {
            try
            {
                WordSet wordSet = new WordSet()
                {
                    Id = wordSet_id,
                    Name = Name,
                    Maker_Id = new Guid(Properties.Settings.Default.UserId),
                };
                Context.WordSets.Update(wordSet);
                Context.SaveChanges();
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        internal bool AddWord(string word)
        {
            try
            {
                Word wordz = new Word()
                {
                    Id = Guid.NewGuid(),
                    Content = word,
                    Maker_Id = new Guid(Properties.Settings.Default.UserId)
                };
                Context.Words.Add(wordz);
                Context.SaveChanges();
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        internal bool AddWordSet(string Name)
        {
            try
            {
                WordSet wordSet = new WordSet()
                {
                    Id = Guid.NewGuid(),
                    Name = Name,
                    Maker_Id = new Guid(Properties.Settings.Default.UserId),
                };
                Context.WordSets.Add(wordSet);
                Context.SaveChanges();
                return true; ;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        internal bool AddWordWordSet(Guid word_Id, Guid WordSet_Id)
        {
            try
            {
                WordWordset WordwordSet = new WordWordset()
                {
                    WordSet_Id = WordSet_Id,
                    Word_Id = word_Id,
                };
                Context.WordWordsets.Add(WordwordSet);
                Context.SaveChanges();
                return true; ;
            }
            catch (Exception Ex)
            {
                return false;
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
                WordSet DeletewordSet = Context.WordSets.Include(i => i.Games).Include(i => i.WordWordset).First(f => f.Id == wordSet_id);
                Context.Remove(DeletewordSet);
                Context.SaveChanges();

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        internal bool DeleteWordWordSet(Guid word_Id, Guid WordSet_Id)
        {
            try
            {
                WordWordset WordwordSet = Context.WordWordsets.First(f => f.Word_Id == word_Id && f.WordSet_Id == WordSet_Id);
                Context.Remove(WordwordSet);
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
