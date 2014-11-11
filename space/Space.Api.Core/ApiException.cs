using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Core
{
    using System.Runtime;
    using System.Diagnostics;
    using System.Reflection;
    
    public class ApiException : Exception
    {
        #region [ Consturctors 
        public ApiException(String Message, Exception inner)
            : base(Message, inner)
        {
            // Set Location of Expeption 
            StackTrace trace = new StackTrace();
            var frame = trace.GetFrames()[1];
            var method = frame.GetMethod();

            this.Location = method;

        }
        #endregion

        public MethodBase Location { get; set; }
    }
}
