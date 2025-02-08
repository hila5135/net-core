using Pool.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core.Repositories
{
    public interface ISwimmerRepository
    {
        public Task<List<Swimmer>> GetAllAsync();
        public Task<Swimmer> GetByIdAsync(int id); 
        public Task<List<Swimmer>> GetSwimmersByGenderAsync(Gender genderSwimmer);
        public Task<Swimmer> PostAsync(Swimmer swimmer);
        public Task<Swimmer> PutAsync(int id, Swimmer swimmer);
        public Task<Swimmer> PutStatusAsync(int id, bool status);

    }
}
