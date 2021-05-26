using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnderstandingTestingandDI.Lib.Core.Abstractions;
using UnderstandingTestingandDI.Lib.Core.Repositories;
using UnderstandingTestingandDI.Lib.Core.Services;
using UnderstandingTestingandDI.Lib.Data;

namespace UnderstandingTestingandDI.Lib.Test
{
    public class TestHelper
    {
        private readonly TestContext testContext;
        public TestHelper()
        {
            var builder = new DbContextOptionsBuilder<TestContext>();
            builder.UseInMemoryDatabase(databaseName: "TestingDb");
            var dbContextOptions = builder.Options;

            testContext = new TestContext(dbContextOptions);
            testContext.Database.EnsureDeleted();
            testContext.Database.EnsureCreated();
        }

        public IUserRepository GetInMemoryUserRepository()
        {
            return new UserRepository(testContext);
        }

        public IUserService GetInMemoryUserService()
        {
            return new UserService(testContext);
        }
    }
}
