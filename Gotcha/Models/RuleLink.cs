using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.Models
{
    class RuleLink
    {
        public Guid Rule_Id { get; set; }
        public Rule Rule { get; set; }

        public Guid RuleSet_Id { get; set; }
        public RuleSet RuleSet { get; set; }
    }
}
