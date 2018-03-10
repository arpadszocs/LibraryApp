using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public interface IService<T>
    {
        List<T> Load();

        void Save(List<T> created ,List<T> modified, List<T> deleted);
    }
}
