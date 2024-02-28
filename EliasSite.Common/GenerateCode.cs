using System;

namespace Elias.Common
{
    public class GenerateCode
    {
        public static string GenerateUniqueCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
