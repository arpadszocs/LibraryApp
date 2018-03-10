using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    interface IDAO<T>
    {
        List<T> SelectAll();

        T SelectOne(long id);

        void Insert(T t);

        void Delete(long id);

        void Delete(T t);

        void Update(T t);

    }
}
