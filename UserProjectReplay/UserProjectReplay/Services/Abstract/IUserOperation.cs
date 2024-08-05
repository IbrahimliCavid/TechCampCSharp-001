using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProjectReplay.Models;

namespace UserProjectReplay.Services.Abstract
{
    public interface IUserOperation : IMainOperation<User>
    {
        bool CheckUser(string email, string password);  
    }
}
