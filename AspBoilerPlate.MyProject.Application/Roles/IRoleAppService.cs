using System.Threading.Tasks;
using Abp.Application.Services;
using AspBoilerPlate.MyProject.Roles.Dto;

namespace AspBoilerPlate.MyProject.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
