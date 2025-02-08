using Microsoft.EntityFrameworkCore;
using Pool.Core.models;
using Pool.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Data.Repositories
{
    public class GuideRepository : IGuideRepository
    {

        private readonly DataContext _context;

        public GuideRepository(DataContext context)
        {
            _context = context;
        }
        public List<Guide> GetAll()
        {
            return _context.guides.Include(g => g.GuideActivities).ToList();
        }
        public Guide GetById(int id)
        {
            Guide g = _context.guides.SingleOrDefault(gui => gui.Id == id);
            if (g != null)
                return g;
            return null;
        }
        public List<Activity> GetGuideActivities(string name)
        {
            Guide g = _context.guides.SingleOrDefault(gui => gui.Name == name);
            if (g != null)
                return g.GuideActivities;
            return null;

        }
        public Guide Post(Guide guide)
        {
            _context.guides.Add(guide);
            return guide;
        }
        public Guide Put(int id, Guide guide)
        {
            Guide g = _context.guides.SingleOrDefault(gui => gui.Id == id);
            if (g == null) return null;
            else
            {
                g.Name = guide.Name;
                g.Age = guide.Age;
                g.GenderGuide = guide.GenderGuide;
                g.GuideActivities = guide.GuideActivities;
            }
            return g;
        }
        public Guide PutStatus(int id, bool status)
        {
            Guide g = _context.guides.SingleOrDefault(gui => gui.Id == id);
            if (g != null)
                g.Status = status;
            return g;
        }

    }
}
