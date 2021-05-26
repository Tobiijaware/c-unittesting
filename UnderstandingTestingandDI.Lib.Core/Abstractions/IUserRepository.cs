using System;
using System.Collections.Generic;
using System.Text;
using UnderstandingTestingandDI.Lib.Models;

namespace UnderstandingTestingandDI.Lib.Core.Abstractions
{
    public interface IUserRepository
    {
        Users Get(string firstname);
    }
}
