using Pool.Core.Dtos;
using Pool.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core.Services
{
    public interface IGuideService
    {

        public List<Guide> GetAll();
        public Guide GetById(int id);
        public List<Activity> GetGuideActivities(string name);
        public Guide Post(GuidePostDTO guide);
        public Guide Put(int id, GuidePutDTO guide);
        public Guide PutStatus(int id, bool status);

    }
}
