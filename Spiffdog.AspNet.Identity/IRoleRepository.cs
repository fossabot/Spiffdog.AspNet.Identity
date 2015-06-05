using System.Threading.Tasks;
using Spiffdog.AspNet.Identity.Identity;

namespace Spiffdog.AspNet.Identity
{
    public interface IRoleRepository<TRole, TRoleKey> where TRole : Role<TRoleKey>
    {
        Task CreateAsync(TRole role);

        Task UpdateAsync(TRole role);

        Task DeleteAsync(TRole role);

        Task<TRole> FindByIdAsync(TRoleKey roleId);

        Task<TRole> FindByNameAsync(string roleName);
    }
}