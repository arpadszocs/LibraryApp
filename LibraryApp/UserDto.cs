using System;


namespace LibraryApp
{
    public class UserDto
    {
        private long? id;
        private string username;
        private string password;

        public UserDto(string username, string password) : this(null, username, password) {
        }
       

        public UserDto(long? id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }

        public long? Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
