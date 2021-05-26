using System;
using System.Collections.Generic;
using System.Linq;
using UnderstandingTestingandDI.Lib.Core.Abstractions;
using UnderstandingTestingandDI.Lib.Data;
using UnderstandingTestingandDI.Lib.Models;

namespace UnderstandingTestingandDI.Lib.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TestContext _testContext;

        public UserRepository(TestContext testContext)
        {
            _testContext = testContext;
        }


        public Users Get(string firstname)
        {
           return _testContext.Users.Where(x => x.FirstName == firstname).FirstOrDefault();
        }
    }
}
