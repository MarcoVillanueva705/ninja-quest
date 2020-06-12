using NinjaQuest.Repositories;

namespace NinjaQuest.Services
{
    public class NinjasService
    {
        private readonly NinjaRepository _repo;
        public NinjasService(NinjaRepository repo)

        {
            _repo = repo;
        }
    }
}
