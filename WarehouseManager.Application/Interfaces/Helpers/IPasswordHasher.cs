using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Application.Interfaces.Helpers;

public interface IPasswordHasher
{
    string GetHashString(string input);
}
