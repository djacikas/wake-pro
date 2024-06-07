using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WakeProApi.Data
{
   public class UsersDbContext : IdentityDbContext
   {
      public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
      {

      }
   }
}
