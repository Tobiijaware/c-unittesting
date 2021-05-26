using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnderstandingTestingandDI.Lib.Core.Abstractions;
using UnderstandingTestingandDI.Lib.Data;
using UnderstandingTestingandDI.Lib.Models;

namespace UnderstandingTestingandDI.Lib.Core.Services
{
    public class UserService : IUserService
    {
       
        private readonly TestContext _testContext;

        public UserService(TestContext testContext)
        {
            _testContext = testContext;
        }


        public bool Registration(string firstname, string lastname, string email, string password)
        {
            bool isRegistered = false;
            var checkexisting = _testContext.Users.FirstOrDefault(x => x.Email == email);
            if (checkexisting == null)
            {
                var newCustomers = new Users() { FirstName = firstname, LastName = lastname, Email = email, Password = password };
                _testContext.Users.Add(newCustomers);
                _testContext.SaveChanges();
            }
            else
            {
                isRegistered = false;
            } 
            return isRegistered;
        }

        public bool Login(string email, string password)
        {
            var checkexisting = _testContext.Users.FirstOrDefault(x => x.Email == email);
            if (checkexisting != null)
                return false;

            return true;

        }
    }
}
