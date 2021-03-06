using service.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace service.Utilities
{
    public interface IServiceSwitch
    {
        Func<object, Task<dynamic>> SetNewAsync { get; }
        Func<Task<IList<dynamic>>> GetAllAsync { get; }
        Func<int, Task<dynamic>> GetByIdAsync { get; }
        Func<string, string, Task<IList<dynamic>>> GetByPropertyAsync { get; }
        Func<int, object, Task<dynamic>> AlterAsync { get; }
        Func<int, Task<bool>> DeleteAsync { get; }

        IServiceSwitch Case(ServiceType serviceType);
    }
}
