using Mde.OnlineServices.Flags.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mde.OnlineServices.Flags.Services
{
    public interface IFlagService
    {
        Task<IEnumerable<Flag>> GetFlags();
    }
}
