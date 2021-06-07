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
    class RuleController
    {
        private Gotcha_DBcontext Context = new Gotcha_DBcontext();

        public RuleController()
        {

        }

        internal Rule GetRuleById(Guid Rule_id)
        {
            try
            {
                Rule Rule = Context.Rules.AsNoTracking().First(f => f.Id == Rule_id);

                return Rule;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        internal RuleSet GetRuleSetById(Guid RuleSet_Id)
        {
            try
            {
                RuleSet RuleSet = Context.RuleSets.AsNoTracking().Include(i => i.RuleRuleSet).ThenInclude(th => th.Rule).AsNoTracking().First(f => f.Id == RuleSet_Id);

                return RuleSet;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        public List<RuleSet> GetAllRuleSets()
        {
            try
            {
                List<RuleSet> List = Context.RuleSets.Include(i => i.User).ToList();

                return List;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
        public List<Rule> GetAllRules()
        {
            try
            {
                List<Rule> List = Context.Rules.Include(i => i.User).ToList();

                return List;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        internal bool UpdateRule(string Rule,string Description, Guid Rule_id)
        {
            try
            {
                Rule Rulez = new Rule()
                {
                    Id = Rule_id,
                    Name = Rule,
                    Description = Description,
                    Maker_Id = new Guid(Properties.Settings.Default.UserId),
                };
                Context.Rules.Update(Rulez);
                Context.SaveChanges();
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        internal bool UpdateRuleSet(string Name, Guid RuleSet_id)
        {
            try
            {
                RuleSet RuleSet = new RuleSet()
                {
                    Id = RuleSet_id,
                    Name = Name,
                    Maker_Id = new Guid(Properties.Settings.Default.UserId),
                };
                Context.RuleSets.Update(RuleSet);
                Context.SaveChanges();
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        internal bool AddRule(string Rule,string Description)
        {
            try
            {
                Rule Rulez = new Rule()
                {
                    Id = Guid.NewGuid(),
                    Name = Rule,
                    Description = Description,
                    Maker_Id = new Guid(Properties.Settings.Default.UserId),
                };
                Context.Rules.Add(Rulez);
                Context.SaveChanges();
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        internal bool AddRuleSet(string Name)
        {
            try
            {
                RuleSet RuleSet = new RuleSet()
                {
                    Id = Guid.NewGuid(),
                    Name = Name,
                    Maker_Id = new Guid(Properties.Settings.Default.UserId),
                };
                Context.RuleSets.Add(RuleSet);
                Context.SaveChanges();
                return true; ;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        internal bool AddRuleRuleSet(Guid Rule_Id, Guid RuleSet_Id)
        {
            try
            {
                RuleRuleSet RuleRuleSet = new RuleRuleSet()
                {
                    RuleSet_Id = RuleSet_Id,
                    Rule_Id = Rule_Id,
                };
                Context.RuleRuleSets.Add(RuleRuleSet);
                Context.SaveChanges();
                return true; ;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        internal bool DeleteRule(Guid Rule_id)
        {
            try
            {
                Rule DeleteRule = Context.Rules.Include(i => i.RuleRuleSet).First(f => f.Id == Rule_id);
                Context.Remove(DeleteRule);
                Context.SaveChanges();

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        internal bool DeleteRuleSet(Guid RuleSet_id)
        {
            try
            {
                RuleSet DeleteRuleSet = Context.RuleSets.Include(i => i.Games).Include(i => i.RuleRuleSet).First(f => f.Id == RuleSet_id);
                Context.Remove(DeleteRuleSet);
                Context.SaveChanges();

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        internal bool DeleteRuleRuleSet(Guid Rule_Id, Guid RuleSet_Id)
        {
            try
            {
                RuleRuleSet RuleRuleSet = Context.RuleRuleSets.First(f => f.Rule_Id == Rule_Id && f.RuleSet_Id == RuleSet_Id);
                Context.Remove(RuleRuleSet);
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
