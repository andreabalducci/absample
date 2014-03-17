using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;

namespace AbSample
{
    public class Engine
    {
        private ILogger _logger;

        public ILogger Logger
        {
            get { return _logger ?? NullLogger.Instance; }
            set { _logger = value; }
        }

        public void Start()
        {
            Logger.Debug("Started v2");
        }

        public void Stop()
        {
            Logger.Debug("Stopped v2");
        }

        public string GetVersion()
        {
            return "v2";
        }
    }
}
