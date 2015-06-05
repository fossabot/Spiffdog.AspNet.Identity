using System;
using Dapper;

namespace Spiffdog.AspNet.Identity.Dapper
{
    public class IdentityDatabase : Database<IdentityDatabase>
    {
        public class StringTable<T> : Table<T, Guid>
        {
            public StringTable(Database<IdentityDatabase> database, string likelyTableName) : base(database, likelyTableName)
            {
            }
        }

        public Table<IdentityRole, Guid> Roles { get; set; }

        public Table<IdentityUser, Guid> Users { get; set; }

        public Table<IdentityUserRole, Guid> UserRoles { get; set; }

        public Table<IdentityUserLogin, Guid> UserLogins { get; set; }

        public Table<IdentityUserClaim, Guid> UserClaims { get; set; } 
    }
}