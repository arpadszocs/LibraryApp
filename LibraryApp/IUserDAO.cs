using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    interface IUserDAO : IDAO<User>
    {
        User SelectByUsername(String username);

        void InsertAll(List<User> users);
    }
}
