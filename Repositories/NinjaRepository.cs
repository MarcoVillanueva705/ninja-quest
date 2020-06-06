using System.Data;
using Dapper;
using NinjaQuest.Models;
//using

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
        public bool Delete(int id)
        {
            int success = _db.Execute(@"
            DELETE FROM ninjas WHERE id = @id
            ", new {id});
        //successful delete if more than 0 lines deleted from db
            return success > 0;
        }

        public Knight FindOneById(int id)
        {
            _db.Query<Knight>(@"
            SELECT * FROM knights WHERE id = @id",
            new {id}).FirstOrDefault();
        }
    }
}