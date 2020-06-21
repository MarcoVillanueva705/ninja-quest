using System.Data;
using Dapper;
using NinjaQuest.Models;

namespace NinjaQuest.Repositories
{
    //IRepo interface helps build out all the methods one needs
    //for db queries etc.
    public class QuestsRepository : IRepository<Quest>
    {
        private readonly IDbConnection _db;

        public QuestsRepository(IDbConnection db)
        {
            _db = db;
        }
        //capital letter means implementation i.e. I or T
        //inherit from classes, but implement interfaces
        public Quest Create(Quest quest)
        {
           int id =  _db.ExecuteScalar<int>(@"
            INSERT INTO quests (title, description)
            VALUES (@Title, @Description)
            ",quest);
            quest.Id = id;
            return quest;
        }
    }
}