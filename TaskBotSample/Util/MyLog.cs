using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBotSample.Util
{
    public class MyLog
    {
        public static ILog Log = LogManager.GetLogger(typeof(MyLog));
    }
}
