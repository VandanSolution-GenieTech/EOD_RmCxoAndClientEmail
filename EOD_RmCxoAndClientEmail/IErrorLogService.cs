using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOD_ClientEmail
{
    public interface IErrorLogService
    {
        void LogException(Exception exception);

    }
}
