// Import log4net classes.
// Import log4net classes.
using log4net;

namespace log4net
{
    public class Bar
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Bar));

        public void DoIt()
        {
            log.Debug("Did it again!");
        }
    }
}
