using System;
using Spiffdog.AspNet.Identity.Identity;

namespace Spiffdog.AspNet.Identity.Dapper
{
    public class IdentityUserRole : UserRole<Guid, Guid, Guid>
    {
        public IdentityUserRole() { }
    }
}