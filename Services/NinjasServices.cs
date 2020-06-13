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
    }
}
