using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core.Repositories
{
    public interface IRepositoryManager
    {
        IActivityRepository Activities { get; }
        IGuideRepository Guides { get; }
        ISwimmerRepository Swimmers { get; }

        Task SaveAsync();
    }
}
