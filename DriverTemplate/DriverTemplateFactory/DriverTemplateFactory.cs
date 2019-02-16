using Automatica.Core.Base.Templates;
using Automatica.Core.Driver;
using System;

namespace DriverTemplate
{
    public class DriverTemplateFactory : DriverFactory
    {
        public override string DriverName => "DriverTemplate";

        public override Guid DriverGuid => new Guid("DRIVER_GUID");
        
        public override Version DriverVersion => new Version(0, 0, 0, 1);

        public override bool InDevelopmentMode => true;

        public override IDriver CreateDriver(IDriverContext config)
        {
            return new DriverTemplateDriver(config);
        }

        public override void InitNodeTemplates(INodeTemplateFactory factory)
        {
            factory.CreateInterfaceType(DriverGuid, "DRIVERTEMPLATE.NAME", "DRIVERTEMPLATE.DESCRIPTION", int.MaxValue, 1, true);
            factory.CreateNodeTemplate(DriverGuid, "DRIVERTEMPLATE.NAME", "DRIVERTEMPLATE.DESCRIPTION", "drivertemplate", GuidTemplateTypeAttribute.GetFromEnum(InterfaceTypeEnum.Virtual),
                DriverGuid, false, true, true, false, true, NodeDataType.NoAttribute, Int32.MaxValue, false);
            
            //TODO: Create your node structure here
        }
    }
}
