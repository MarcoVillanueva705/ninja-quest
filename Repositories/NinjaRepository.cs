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
        //create will be handled in next vid
        {
            //run many sql commands and return w/e last sql command returns
            int id = _db.ExecuteScalar<int>(@"
            INSERT INTO ninjas (name) VALUES (@name); 
            SELECT LAST_INSERT_ID()", new {name}
            );

            //return the ninja created
            return new Ninja() { Name = name, Id = id};
        }
    }
}