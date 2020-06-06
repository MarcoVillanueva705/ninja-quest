using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        //delete a ninja by id
        public bool Delete(int id)
        {
            int success = _db.Execute(@"
            DELETE FROM ninjas WHERE id = @id
            ", new {id});
        //successful delete if more than 0 lines deleted from db
            return success > 0;
        }

        public Ninja FindOneById(int id)
        {
            //query db and find specific ninja
           return _db.Query<Ninja>(@"
            SELECT * FROM knights WHERE id = @id",
            //query will return a list
            new {id}).FirstOrDefault();
        }
        //find all ninjas
        public List<Ninja> Find()
        {
            return _db.Query<Ninja>(@"
            SELECT * FROM ninjas").ToList();
        }
        // ** left off after CRUD vid ** //
    }
}