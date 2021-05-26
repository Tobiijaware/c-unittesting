using System;
using System.Collections.Generic;
using System.Text;
using UnderstandingTestingandDI.Lib.Models;

namespace UnderstandingTestingandDI.Lib.Core.Abstractions
{
    public interface IUserService
    {
        bool Registration(string firstname, string lastname, string email, string password);
        bool Login(string email, string password);
    }
}
