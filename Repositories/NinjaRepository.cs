using System.Data;
using Dapper;
using NinjaQuest.Models;

namespace NinjaQuest.Repositories
{
    public class NinjaRepository
    {
        private readonly IDbConnection _db;

        public NinjaRepository(IDbConnection db)
        {
            _db = db;
        }
        //create Ninja and put into SQL db via Dapper
        public Ninja Create(string name) 
        {
            _db.Execute("INSERT INTO ninjas (name) VALUES (@name)", new { name });
        }
    }
}