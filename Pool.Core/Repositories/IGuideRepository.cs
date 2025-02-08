using Pool.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core.Repositories
{
    public interface IGuideRepository
    {
        public List<Guide> GetAll();
        public Guide GetById(int id);
        public List<Activity> GetGuideActivities(string name);
        public Guide Post(Guide guide);
        public Guide Put(int id, Guide guide);
        public Guide PutStatus(int id, bool status);

    }
}
