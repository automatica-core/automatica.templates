using Automatica.Core.Base.Templates;
using Automatica.Core.Rule;
using System;

namespace DriverTemplate
{
    public class RuleTemplateNameFactory : RuleFactory
    {
        public override string RuleName => "RuleTemplateName";

        public override Guid RuleGuid => new Guid("RULE_GUID");

        public override Version RuleVersion => new Version(0, 0, 0, 1);

        public override bool InDevelopmentMode => true;

        public override IRule CreateRuleInstance(IRuleContext context)
        {
            return new RuleTemplateNameRule(context);
        }

        public override void InitTemplates(IRuleTemplateFactory factory)
        {
            factory.CreateRuleTemplate(RuleGuid, "RULETEMPLATENAME.NAME", "RULETEMPLATNAME.DESCRIPTION",
               "ruletemplatename", "RULETEMPLATENAME.NAME", 100, 100);
        }
    }
}
