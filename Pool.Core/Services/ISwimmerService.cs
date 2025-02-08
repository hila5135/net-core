using Pool.Core.Dtos;
using Pool.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core.Services
{
    public interface ISwimmerService
    {
        public Task<List<Swimmer>> GetAllAsync();
        public Task< Swimmer> GetByIdAsync(int id);
        public Task< List<Swimmer>> GetSwimmersByGenderAsync(Gender genderSwimmer);
        public Task<Swimmer> PostAsync(SwimmerPostDTO swimmer);
        public Task<Swimmer> PutAsync(int id, SwimmerPutDTO swimmer);
        public Task<Swimmer> PutStatusAsync(int id, bool status);
    }
}
