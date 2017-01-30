using Abp.Authorization;
using AspBoilerPlate.MyProject.Authorization.Roles;
using AspBoilerPlate.MyProject.MultiTenancy;
using AspBoilerPlate.MyProject.Users;

namespace AspBoilerPlate.MyProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
