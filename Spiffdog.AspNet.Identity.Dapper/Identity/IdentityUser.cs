using System;
using Spiffdog.AspNet.Identity.Identity;

namespace Spiffdog.AspNet.Identity.Dapper
{
    public class IdentityUser : User<Guid>
    {
        public IdentityUser()
        {
            Id = Guid.NewGuid();
        }
    }
}