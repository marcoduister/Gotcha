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
                WordSet wordSet = Context.WordSets.Include(i => i.WordWordset).ThenInclude(th =>th.Word).AsNoTracking().First(f => f.Id == wordSet_Id);

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
                    Maker_Id = new Guid("6b6ac9b4-ebec-4098-bfd7-af1fa0f79b6c")
                };
                //Alert hier moet ingeloged gebruiker id nog bij
                Context.Words.Update(wordz);
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
                    Maker_Id = new Guid("6b6ac9b4-ebec-4098-bfd7-af1fa0f79b6c")
            };
                //Alert hier moet ingeloged gebruiker id nog bij
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
                    Maker_Id = new Guid("6b6ac9b4-ebec-4098-bfd7-af1fa0f79b6c")
                };
                //Alert hier moet ingeloged gebruiker id nog bij
                Context.WordSets.Add(wordSet);
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
