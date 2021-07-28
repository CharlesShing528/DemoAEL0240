using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoEL0240.Models;

namespace DemoEL0240.Data
{
    public class FriendContext : DbContext
    {
        public FriendContext (DbContextOptions<FriendContext> options)
            : base(options)
        {
        }

        public DbSet<DemoEL0240.Models.Friend> Friend { get; set; }
    }
}
