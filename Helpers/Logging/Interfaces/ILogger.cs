using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Logging.Interfaces
{
    public interface ILogger
    {
        void Error(string text);

        void Warning(string text);

        void Info(string text);
    }
}
