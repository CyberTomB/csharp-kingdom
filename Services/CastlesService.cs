using System;
using System.Collections.Generic;
using csharp_kingdom.Models;
using csharp_kingdom.Repositories;

namespace csharp_kingdom.Services
{
    public class CastlesService
    {
        private readonly CastlesRepository _repo;

        public CastlesService(CastlesRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<Castle> Get(){
            return _repo.Get();
        }

        internal Castle Get(string id)
        {
            Castle castle = _repo.Get(id);
            if(castle == null)
            {
                throw new Exception("Invalid Id");
            }
            return castle;
        }
    }
}