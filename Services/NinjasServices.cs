using System.Collections.Generic;
using NinjaQuest.Models;
using NinjaQuest.Repositories;

namespace NinjaQuest.Services
{
    public class NinjasService
    {
        private readonly NinjaRepository _repo;
        //dependency injection; see startup.cs line 42
        public NinjasService(NinjaRepository repo)

        {
            _repo = repo;
        }

        public Ninja Create(string name)
        {
            //_repo is the NinjaRepository accessed
            //through services; Create is the method
            //in _repo too
            return _repo.Create(name);
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public Ninja FindById(int id)
        {
            return _repo.FindOneById(id);
        }

        public List<Ninja> Find()
        {
            return _repo.Find();
        }
    }
}
