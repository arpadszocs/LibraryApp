using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public interface IUserService : IService<UserDto>
    {
         void RegisterUser(UserDto user);
    }
}
