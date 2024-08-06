using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Application.Interfaces.Helpers;

namespace WarehouseManager.Application.Helpers;

internal class PasswordHasher : IPasswordHasher
{
    public string GetHashString(string input)
    {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in GetHash(input))
            sb.Append(b.ToString("X2"));

        return sb.ToString();
    }

    private byte[] GetHash(string input)
    {
        using HashAlgorithm algorithm = SHA256.Create();
        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
    }
}
