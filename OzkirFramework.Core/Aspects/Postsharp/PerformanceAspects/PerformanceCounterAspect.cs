using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Core.Aspects.Postsharp.LogAspects;
using OzkirFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using PostSharp.Aspects;

namespace OzkirFramework.Core.Aspects.Postsharp.PerformanceAspects
{
    [Serializable]
    public class PerformanceCounterAspect:OnMethodBoundaryAspect
    {
        private int _interval;
        [NonSerialized]
        private Stopwatch _stopwatch;

        public PerformanceCounterAspect(int interval=5)
        {
            _interval = interval;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            _stopwatch = Activator.CreateInstance<Stopwatch>();
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            _stopwatch.Start();
            base.OnEntry(args);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            _stopwatch.Stop();
            if (_stopwatch.Elapsed.TotalSeconds>_interval)
            {
                string message=string.Format("Performance: {0}.{1} --> {2}",
                    args.Method.DeclaringType.FullName,
                    args.Method.Name,
                    _stopwatch.Elapsed.TotalSeconds
                    );
              FileLogger log=new FileLogger();
                log.Info(message);

            }
            _stopwatch.Reset();
            base.OnExit(args);
        }
    }
}
