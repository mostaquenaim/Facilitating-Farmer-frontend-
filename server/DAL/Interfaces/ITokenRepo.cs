using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ITokenRepo<TClass>
    {
        TClass Add(TClass @obj);

        List<TClass> Get();

        TClass Get(string Id);

        TClass Update(TClass @obj);

        TClass Delete(int Id);

    }
}
