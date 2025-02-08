using Pool.Core.Repositories;
using Pool.Core.models;
using Pool.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Core.Services;
using AutoMapper;
using Pool.Core.Dtos;

namespace Pool.Service
{
    public class GuideService : IGuideService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public GuideService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public List<Guide> GetAll()
        {
            return _repositoryManager.Guides.GetAll();
        }

        public Guide GetById(int id)
        {
            return _repositoryManager.Guides.GetById(id);
        }
        public List<Activity> GetGuideActivities(string name)
        {
            return _repositoryManager.Guides.GetGuideActivities(name);
        }
        public Guide Post(GuidePostDTO guide)
        {
            var guideMap = _mapper.Map<Guide>(guide);
            var res = _repositoryManager.Guides.Post(guideMap);
            _repositoryManager.SaveAsync();
            return res;
        }

        public Guide Put(int id, GuidePutDTO guide)
        {
            var guideMap = _mapper.Map<Guide>(guide);

            var res = _repositoryManager.Guides.Put(id, guideMap);
            _repositoryManager.SaveAsync();
            return res;

        }


        public Guide PutStatus(int id, bool status)
        {
            var res = _repositoryManager.Guides.PutStatus(id, status);
            _repositoryManager.SaveAsync();
            return res;

        }

    }
}
