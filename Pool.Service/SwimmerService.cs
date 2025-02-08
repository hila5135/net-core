using AutoMapper;
using Pool.Core.Dtos;
using Pool.Core.models;
using Pool.Core.Repositories;
using Pool.Core.Services;
using Pool.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pool.Service
{
    public class SwimmerService : ISwimmerService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public SwimmerService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task< List<Swimmer>> GetAllAsync()
        {
            return await _repositoryManager.Swimmers.GetAllAsync();
        }
        public async Task<Swimmer> GetByIdAsync(int id)
        {
            return await _repositoryManager.Swimmers.GetByIdAsync(id);
        }
        public async Task< List<Swimmer>> GetSwimmersByGenderAsync(Gender genderSwimmer)
        {
            return await _repositoryManager.Swimmers.GetSwimmersByGenderAsync(genderSwimmer);
        }
        public async Task<Swimmer> PostAsync(SwimmerPostDTO swimmer)
        {
            var swimmeryMap = _mapper.Map<Swimmer>(swimmer);

            var res = await _repositoryManager.Swimmers.PostAsync(swimmeryMap);
            _repositoryManager.SaveAsync();
            return res;
        }

        public async Task< Swimmer> PutAsync(int id, SwimmerPutDTO swimmer)
        {
            var swimmeryMap = _mapper.Map<Swimmer>(swimmer);

            var res = await _repositoryManager.Swimmers.PutAsync(id, swimmeryMap);
            _repositoryManager.SaveAsync();
            return res;
        }
        public async Task< Swimmer> PutStatusAsync(int id, bool status)
        {
            var res = await _repositoryManager.Swimmers.PutStatusAsync(id, status);
            _repositoryManager.SaveAsync();
            return res;
        }

    }
}
