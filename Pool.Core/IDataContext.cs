using Microsoft.EntityFrameworkCore;
using Pool.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core
{
    public interface IDataContext
    {

        public DbSet<Activity> activities { get; set; }
        public DbSet<Guide> guides { get; set; }
        public DbSet<Swimmer> swimmers { get; set; }
    }
}
