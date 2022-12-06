using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3.CustomException
{
    internal class OverRangeException : Exception
    {
        public OverRangeException(string message) : base(message) { }
    }
}
