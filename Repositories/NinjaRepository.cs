using System.Data;

namespace NinjaQuest.Repositories
{
    public class NinjaRepository
    {
        private readonly IDbConnection _db;

        public NinjaRepository(IDbConnection db)
        {
            _db = db;
        }
    }
}