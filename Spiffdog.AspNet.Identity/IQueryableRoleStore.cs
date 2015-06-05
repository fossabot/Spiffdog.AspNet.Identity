using System;
using MsId = Microsoft.AspNet.Identity;

namespace Spiffdog.AspNet.Identity
{
    public interface IQueryableRoleStore<TRole, TKey> : MsId.IQueryableRoleStore<TRole, TKey> where TRole : MsId.IRole<TKey>
    {

    }
}
