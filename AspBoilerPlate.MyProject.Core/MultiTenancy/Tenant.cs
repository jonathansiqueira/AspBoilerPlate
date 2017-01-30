using Abp.MultiTenancy;
using AspBoilerPlate.MyProject.Users;

namespace AspBoilerPlate.MyProject.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}