using Microsoft.EntityFrameworkCore;
using System;
using TestSupport.EfHelpers;
using UnderstandingTestingandDI.Lib.Core;
using UnderstandingTestingandDI.Lib.Data;
using Xunit;

namespace UnderstandingTestingandDI.Lib.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var helper = new TestHelper();

            var readyrepo = helper.GetInMemoryUserRepository();
            var service = helper.GetInMemoryUserService();

            service.Registration("Josh", "Gbogodor", "josh@gmail.com", "0000");

            var result = readyrepo.Get("Josh");
            Assert.NotNull(result);
            Assert.Equal("chika", result.FirstName);


        }
    }
}
