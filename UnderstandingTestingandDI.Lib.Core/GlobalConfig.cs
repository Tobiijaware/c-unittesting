using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using UnderstandingTestingandDI.Lib.Core.Abstractions;
using UnderstandingTestingandDI.Lib.Core.Repositories;
using UnderstandingTestingandDI.Lib.Core.Services;
using UnderstandingTestingandDI.Lib.Data;

namespace UnderstandingTestingandDI.Lib.Core
{
    public class GlobalConfig
    {
        public static TestContext TestInstance { get; set; }
        public static IUserService UserService { get; set; }
        public static IUserRepository UserRepository { get; set; }

        private static string conStr = @"Data Source = C:\Users\hp\source\repos\UnderstandingTestingandDI\UnderstandingTestingandDI.Lib.Data\UnderstandingTestingandDI";
             
        
        public static void AddIinstance()
        {
            TestInstance = new TestContext(conStr);
            UserService = new UserService(TestInstance);
            UserRepository = new UserRepository(TestInstance);

        }

    }
}
