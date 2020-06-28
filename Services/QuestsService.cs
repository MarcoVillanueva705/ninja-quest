using System;
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
            //business rule
            //user == admin role
            //allow the quest.completed
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

        public Quest FindById(int id)
        {
            return _repo.FindById(id);
        }
    }
    
//fill out qs
    
}
