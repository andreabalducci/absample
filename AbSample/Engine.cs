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
            Logger.Debug("Started " + GetVersion());
        }

        public void Stop()
        {
            Logger.Debug("Stopped " + GetVersion());
        }

        public string GetVersion()
        {
            return "v3";
        }
    }
}
