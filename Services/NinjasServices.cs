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
            //_repo is the NinjaRepository, Create is the method
            //in _repo too
            return _repo.Create(name);
        }
    }
}
