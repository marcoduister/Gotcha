using Gotcha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.DAL
{
    class DataSeeder
    {
        Gotcha_DBcontext DBContext = new Gotcha_DBcontext();
        public void CreadeData()
        {
            if (!DBContext.Users.Any())
            {
                DBContext.Users.Add(new User { Id = new Guid("f123873f-1278-49bb-acbb-6c0872ad52a9"), FirstName = "Marco", LastName = "Duister", Email = "marco@zuyd.nl", Password = "Qwerty1234", Rol = Enums.Rolen.Admin, Birthdate = DateTime.Now, UserActive = true });
                DBContext.Users.Add(new User { Id = new Guid("258484ab-4779-4894-820b-d62a3a8dda77"), FirstName = "Julean", LastName = "Hommel", Email = "julean@zuyd.nl", Password = "Qwerty1234", Rol = Enums.Rolen.Player, Birthdate = DateTime.Now, UserActive = false });
                DBContext.Users.Add(new User { Id = new Guid("9f7815c1-f83b-4f6b-a77b-a421355ab8f1"), FirstName = "Stan", LastName = "Kikken", Email = "stan@zuyd.nl", Password = "Qwerty1234", Rol = Enums.Rolen.Player, Birthdate = DateTime.Now, UserActive = false });
                DBContext.Users.Add(new User { Id = new Guid("6404bfc6-442a-49f8-bbd4-05bc400f6f6b"), FirstName = "Salem", LastName = "Jatic", Email = "salem@zuyd.nl", Password = "Qwerty1234", Rol = Enums.Rolen.Player, Birthdate = DateTime.Now, UserActive = false });
                DBContext.Users.Add(new User { Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c"), FirstName = "Miel", LastName = "Noelanders", Email = "miel@zuyd.nl", Password = "Qwerty1234", Rol = Enums.Rolen.Gamemaster, Birthdate = DateTime.Now, UserActive = true }); 
                DBContext.SaveChanges();
            }
            if (!DBContext.Words.Any())
            {
                DBContext.Words.Add(new Word { Id = new Guid("95a43da6-e414-42bd-aaab-471c51240374"), Content = "eloquent", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });
                DBContext.Words.Add(new Word { Id = new Guid("d834b5c5-847f-4362-aeb3-024ffedf6143"), Content = "idyllisch", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });
                DBContext.Words.Add(new Word { Id = new Guid("daa5c6ee-03ce-427d-9ffe-18471b72c085"), Content = "traditiegetrouw", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });
                DBContext.Words.Add(new Word { Id = new Guid("5cbf789e-f4f0-4211-91ec-7adc4b9e3e31"), Content = "integratie", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });
                DBContext.Words.Add(new Word { Id = new Guid("d00e3a2d-8654-41c7-bace-b3345d339348"), Content = "concreet", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });
                DBContext.SaveChanges();
            }
            if (!DBContext.Rules.Any())
            {
                DBContext.Rules.Add(new Rule { Id = new Guid("dd46a79c-4208-4148-963d-b5445db52d75"), Name = "Locatie vrij", Description ="WC's", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });
                DBContext.Rules.Add(new Rule { Id = new Guid("e2f54b40-f061-464b-8ecf-f4fb15992280"), Name = "Cominicatie", Description = "er moet minimaal 2 mailtjes binnen komen", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });
                DBContext.Rules.Add(new Rule { Id = new Guid("a9190c0c-df5f-44b5-bccb-e17ac5d77288"), Name = "concreet", Description = "je moet iemand laten weten dat die een word gezegt heeft", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });
                DBContext.SaveChanges();
            }
            if (!DBContext.GameTypes.Any())
            {
                DBContext.GameTypes.Add(new GameType { Id = new Guid("c3380916-0b52-4e0c-b247-780a51d8e3d6"), Name = "wordspel", Description = "dit is de worden variant je moet iemand een word laten zeggen", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });
                DBContext.GameTypes.Add(new GameType { Id = new Guid("5cf1d9fc-bf24-465a-98e8-09bef6f1bfdf"), Name = "waterspel", Description = "je moet iemand nat maken", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });
                DBContext.GameTypes.Add(new GameType { Id = new Guid("ba84f4a6-f9f3-4a67-82d7-4b9c357c2930"), Name = "paintball spel", Description = "je moet iemand raken met paint ball", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });

                DBContext.SaveChanges();

            }
            if (!DBContext.RuleSets.Any())
            {
                DBContext.RuleSets.Add(new RuleSet { Id = new Guid("34247f9c-c993-46d9-86a5-a8d4cd6117ba"), Name = "WordenRegelSet", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });
                DBContext.RuleSets.Add(new RuleSet { Id = new Guid("086ed90c-e88b-4fd6-8e06-1d4cb9cf2767"), Name = "waterRegelSet",  Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });
                DBContext.RuleSets.Add(new RuleSet { Id = new Guid("e39d30d3-79d8-4a36-944f-1da6b7a72d6b"), Name = "paintballregelSet", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });

                DBContext.SaveChanges();
            }
            if (!DBContext.RuleRuleSets.Any())
            {
                DBContext.RuleRuleSets.Add(new RuleRuleSet { RuleSet_Id = new Guid("34247f9c-c993-46d9-86a5-a8d4cd6117ba"), Rule_Id = new Guid("dd46a79c-4208-4148-963d-b5445db52d75") });
                DBContext.RuleRuleSets.Add(new RuleRuleSet { RuleSet_Id = new Guid("34247f9c-c993-46d9-86a5-a8d4cd6117ba"), Rule_Id = new Guid("e2f54b40-f061-464b-8ecf-f4fb15992280") });
                DBContext.RuleRuleSets.Add(new RuleRuleSet { RuleSet_Id = new Guid("086ed90c-e88b-4fd6-8e06-1d4cb9cf2767"), Rule_Id = new Guid("dd46a79c-4208-4148-963d-b5445db52d75") });
                DBContext.RuleRuleSets.Add(new RuleRuleSet { RuleSet_Id = new Guid("086ed90c-e88b-4fd6-8e06-1d4cb9cf2767"), Rule_Id = new Guid("a9190c0c-df5f-44b5-bccb-e17ac5d77288") });

                DBContext.SaveChanges();
            }
            if (!DBContext.WordSets.Any())
            {
                DBContext.WordSets.Add(new WordSet { Id = new Guid("4aeab999-f954-48ac-ae14-ed080ec9e108"), Name = "WordenSet1", Maker_Id = new Guid("dbcb68de-6442-487b-8868-b3075347af7c") });
                DBContext.SaveChanges();
            }
            if (!DBContext.WordWordsets.Any())
            {
                DBContext.WordWordsets.Add(new WordWordset { WordSet_Id = new Guid("4aeab999-f954-48ac-ae14-ed080ec9e108"), Word_Id = new Guid("95a43da6-e414-42bd-aaab-471c51240374") });
                DBContext.WordWordsets.Add(new WordWordset { WordSet_Id = new Guid("4aeab999-f954-48ac-ae14-ed080ec9e108"), Word_Id = new Guid("d834b5c5-847f-4362-aeb3-024ffedf6143") });
                DBContext.WordWordsets.Add(new WordWordset { WordSet_Id = new Guid("4aeab999-f954-48ac-ae14-ed080ec9e108"), Word_Id = new Guid("daa5c6ee-03ce-427d-9ffe-18471b72c085") });
                DBContext.WordWordsets.Add(new WordWordset { WordSet_Id = new Guid("4aeab999-f954-48ac-ae14-ed080ec9e108"), Word_Id = new Guid("5cbf789e-f4f0-4211-91ec-7adc4b9e3e31") });
                DBContext.WordWordsets.Add(new WordWordset { WordSet_Id = new Guid("4aeab999-f954-48ac-ae14-ed080ec9e108"), Word_Id = new Guid("d00e3a2d-8654-41c7-bace-b3345d339348") });
                DBContext.SaveChanges();
            }
            if (!DBContext.Games.Any())
            {
                DBContext.Games.Add(new Game { Id = new Guid("97a58278-91ed-4722-9503-0da3df2b80f7"), Name = "Gotcha2021",   Location = "Nieuw Eyckholt 300, 6419 DJ Heerlen", Archived = false, Maker_Id  = new Guid("dbcb68de-6442-487b-8868-b3075347af7c"), WordSet_Id = new Guid("4aeab999-f954-48ac-ae14-ed080ec9e108"), RuleSet_Id = new Guid("34247f9c-c993-46d9-86a5-a8d4cd6117ba"), GameType_Id = new Guid("c3380916-0b52-4e0c-b247-780a51d8e3d6") });
                DBContext.SaveChanges();
            }
            if(!DBContext.Contracts.Any())
            {
                DBContext.Contracts.Add(new Contract { Id = Guid.NewGuid(), Game_Id = new Guid("97a58278-91ed-4722-9503-0da3df2b80f7"), User_Id = new Guid("258484ab-4779-4894-820b-d62a3a8dda77"), Eliminations = 0, EliminatedTime = null });
                DBContext.Contracts.Add(new Contract { Id = Guid.NewGuid(), Game_Id = new Guid("97a58278-91ed-4722-9503-0da3df2b80f7"), User_Id = new Guid("6404bfc6-442a-49f8-bbd4-05bc400f6f6b"), Eliminations = 0, EliminatedTime = null });
                DBContext.Contracts.Add(new Contract { Id = Guid.NewGuid(), Game_Id = new Guid("97a58278-91ed-4722-9503-0da3df2b80f7"), User_Id = new Guid("9f7815c1-f83b-4f6b-a77b-a421355ab8f1"), Eliminations = 0, EliminatedTime = null,});
                DBContext.SaveChanges();
            }
        }
    }
}
