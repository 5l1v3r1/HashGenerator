using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashGenerator.core.hashing
{
    internal sealed class hgSHA256 : hgHashAlgorithm
    {
        public String ComputeHash(String filename)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                using (FileStream stream = File.OpenRead(filename))
                {
                    return BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }
    }
}
