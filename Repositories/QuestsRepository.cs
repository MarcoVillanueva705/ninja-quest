using NinjaQuest.Models;

namespace NinjaQuest.Repositories
{
    public class QuestsRepository : IRepository<Quest>
    {
        //capital letter means implementation i.e. I or T
        //inherit from classes, but implement interfaces
        public Quest Create(Quest quest)
        {
            throw new System.NotImplementedException();
        }
    }
}