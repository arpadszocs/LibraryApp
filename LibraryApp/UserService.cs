using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class UserService : IUserService
    {
        private IUserDAO userDAO = new UserDAO();

        public List<UserDto> Load()
        {
            List<UserDto> userDtos = new List<UserDto>();
            List<User> users = userDAO.SelectAll();
            foreach (var user in users)
            {
                userDtos.Add(new UserDto(user.Id, user.Username, user.Password));
            }
            return userDtos;
        }

        public void RegisterUser(UserDto userDto)
        {
            User user = new User
            {
                Username = userDto.Username,
                Password = userDto.Password
            };
            userDAO.Insert(user);
           
        }

        public void Save(List<UserDto> created, List<UserDto> modified, List<UserDto> deleted)
        {
            // new users
            List<User> newUsers = new List<User>();
            foreach (var userDto in created)
            {
                User user = new User
                {
                    Username = userDto.Username,
                    Password = userDto.Password
                };
                newUsers.Add(user);
            }
            userDAO.InsertAll(newUsers);

            // modified users
            foreach (var userDto in modified)
            {
                User user = userDAO.SelectOne(userDto.Id.GetValueOrDefault());
                user.Username = userDto.Username;
                user.Password = userDto.Password;
                userDAO.Update(user);
            }

            // deleted users
            foreach (var userDto in deleted)
            {
                User user = userDAO.SelectOne(userDto.Id.GetValueOrDefault());
                userDAO.Delete(user);
            }
        }
    }
}
