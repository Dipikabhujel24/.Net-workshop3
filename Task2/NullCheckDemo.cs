using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class NullOperations
    {
            public void PerformNullChecks()
            {
                string username = null;

                // 1. Using Ternary Operator
                string resultTernary = (username != null) ? username : "Username is not available";
                Console.WriteLine("Ternary Operator: " + resultTernary);

                // 2. Using Null-Coalescing Operator
                string resultCoalescing = username ?? "Username is not available";
                Console.WriteLine("Null-Coalescing Operator: " + resultCoalescing);

                // 3. Using Null-Coalescing Assignment Operator
                username ??= "DefaultUser";
                Console.WriteLine("After Null-Coalescing Assignment: " + username);
            }
        }
    }
