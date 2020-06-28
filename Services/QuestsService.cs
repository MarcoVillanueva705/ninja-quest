using System.Collections.Generic;
using NinjaQuest.Models;
using NinjaQuest.Repositories;

namespace NinjaQuest.Services
{
    public class QuestsService
    {
        private readonly QuestsRepository _repo;

        public QuestsService(QuestsRepository repo)
        {
            _repo = repo;
        }
        public Quest Create(Quest q)
        {
            return _repo.Create(q);
        }
        public List<Quest> Find()
        {
            return _repo.Find();
        }
        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }
    }
    
//fill out qs
    
}
