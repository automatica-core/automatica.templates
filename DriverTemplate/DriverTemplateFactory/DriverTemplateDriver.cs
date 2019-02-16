using Automatica.Core.Driver;

namespace DriverTemplate
{
    public class DriverTemplateDriver : DriverBase
    {
        public DriverTemplateDriver(IDriverContext driverContext) : base(driverContext)
        {
        }

        public override IDriverNode CreateDriverNode(IDriverContext ctx)
        {
            return null;
        }
    }
}
