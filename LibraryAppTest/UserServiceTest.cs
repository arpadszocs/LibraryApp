﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryApp;
using System.Collections.Generic;

namespace LibraryAppTest
{
    [TestClass]
    public class UserServiceTest
    {
        IUserService service;

        [TestInitialize]
        public void Setup()
        {
           service = new UserService();
            
        }


        [TestMethod]
        public void TestLoad()
        {
            List<UserDto> users = new List<UserDto>
            {
                new UserDto("Name", "Pwd"),
                new UserDto("Name", "Pwd"),
                new UserDto("Name", "Pwd")
            };
            service.Save(users, new List<UserDto>(), new List<UserDto>());
            users = service.Load();
            try
            { 
                Assert.AreEqual(3, users.Count);
            }
            finally
            {
                service.Save(new List<UserDto>(), new List<UserDto>(),users);
            }
        }

        [TestMethod]
        public void TestUpdate()
        {

        }
    }
}
