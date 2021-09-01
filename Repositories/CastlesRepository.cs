using System.Collections.Generic;
using System.Data;
using System.Linq;
using csharp_kingdom.Models;
using Dapper;

namespace csharp_kingdom.Repositories
{
    public class CastlesRepository
    {
        private readonly IDbConnection _db;
        public CastlesRepository(IDbConnection db)
        {
            _db = db;
        }

        internal List<Castle> Get()
        {
            string sql = "SELECT * FROM castles";
            return _db.Query<Castle>(sql).ToList();
        }

        internal Castle Get(string id)
        {
            string sql = "SELECT * FROM castles WHERE id = @id";
            return _db.QueryFirstOrDefault<Castle>(sql, new {id});
        }
    }
}