using Pool.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pool.Data.Repositories.RepositoryManager;

namespace Pool.Data.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _context;
       public  IActivityRepository Activities { get; }
        public IGuideRepository Guides { get; }
        public ISwimmerRepository Swimmers { get; }
        public RepositoryManager(DataContext context, IActivityRepository activityRepository, IGuideRepository guideRepository,ISwimmerRepository swimmerRepository)
        {
            _context = context;
            Activities=activityRepository;
            Guides=guideRepository;
            Swimmers=swimmerRepository;
        }

    public async Task SaveAsync()
    {
      await _context.SaveChangesAsync();
    }
  }

}
