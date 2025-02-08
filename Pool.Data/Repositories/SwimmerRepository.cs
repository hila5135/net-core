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
    public class SwimmerRepository : ISwimmerRepository
    {
        private readonly DataContext _context;

        public SwimmerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Swimmer>> GetAllAsync()
        {
            return await _context.swimmers.Include(s => s.SwimmerActivities).ToListAsync();
        }
        public async Task<Swimmer> GetByIdAsync(int id)
        {
            Swimmer s =await _context.swimmers.SingleOrDefaultAsync(swi => swi.Id == id);
            if (s != null)
                return s;
            return null;
        }
        public async Task< List<Swimmer>> GetSwimmersByGenderAsync(Gender genderSwimmer)
        {
            return await _context.swimmers.Where(s => s.GenderSwimmer == genderSwimmer).ToListAsync();
        }
        public async Task<Swimmer> PostAsync(Swimmer swimmer)
        {
           await _context.swimmers.AddAsync(swimmer);
            return swimmer;
        }
        public async Task<Swimmer> PutAsync(int id, Swimmer swimmer)
        {
            Swimmer s =await _context.swimmers.SingleOrDefaultAsync(swi => swi.Id == id);
            if (s == null) return null;
            else
            {
                s.Name = swimmer.Name;
                s.Age = swimmer.Age;
                s.GenderSwimmer = swimmer.GenderSwimmer;
                s.SwimmerActivities = swimmer.SwimmerActivities;
            }
            return s;
        }
        public async Task<Swimmer> PutStatusAsync(int id, bool status)
        {
            Swimmer s =await _context.swimmers.SingleOrDefaultAsync(swi => swi.Id == id);
            if (s != null)
                s.Status = status;
            return s;
        }
    }
}
