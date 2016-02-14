using System.Data.Entity;

namespace SomeParser
{
    public class AutoRiaContext : DbContext
    {
        public DbSet<UserInfo> UserInfos { get; set; }
    }
}