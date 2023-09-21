using DesingPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Repository
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> Get();

        Beer Get(int id);

        void Add(Beer data);
        void Delete(int id);
        void Update(Beer data);

        void Save();

    }
}
