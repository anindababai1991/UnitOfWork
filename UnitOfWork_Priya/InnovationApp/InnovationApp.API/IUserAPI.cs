using InnovationApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationApp.API
{
    public interface IUserAPI: IDisposable
    {
        List<User> GetUsers();
    }
}
