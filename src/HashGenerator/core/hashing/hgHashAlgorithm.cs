using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashGenerator.core.hashing
{
    interface hgHashAlgorithm
    {
        String ComputeHash(String filename);
    }
}
