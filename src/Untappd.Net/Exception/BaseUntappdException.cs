using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Untappd.Net.Exception
{
    [Serializable]
    public class BaseUntappdException : System.Exception
    {
       public BaseUntappdException()
        {
        }
        
        public BaseUntappdException(string message) : base(message)
        {
        }

        public BaseUntappdException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected BaseUntappdException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
