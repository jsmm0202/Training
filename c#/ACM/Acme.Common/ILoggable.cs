using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Common
{
    public interface ILoggable
    {
        string Log(); // why you return string ??
    }
}
