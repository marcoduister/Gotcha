using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.Models
{
    class RuleRuleSet
    {
        //Atributte/property
        public Guid Rule_Id { get; set; }
        public Guid RuleSet_Id { get; set; }

        //Relations
        public Rule Rule { get; set; }
        public RuleSet RuleSet { get; set; }
    }
}
