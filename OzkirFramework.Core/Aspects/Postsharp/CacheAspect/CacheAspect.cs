using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Core.CrossCuttingConcerns.Caching;
using PostSharp.Aspects;

namespace OzkirFramework.Core.Aspects.Postsharp.CacheAspect
{
    [Serializable]
    public class CacheAspect:MethodInterceptionAspect
    {
        private Type _cacheType;
        private int _cacheByMinute;
        private ICacheManager _cacheManager;

        public CacheAspect(Type cacheType, int cacheByMinute=60)
        {
            _cacheType = cacheType;
            _cacheByMinute = cacheByMinute;
        }
        public override void RuntimeInitialize(MethodBase method)
        {
            if (!typeof(ICacheManager).IsAssignableFrom(_cacheType))
            {
                throw new Exception("Wrong Cache Manager");
            }
            _cacheManager = (ICacheManager) Activator.CreateInstance(_cacheType);
        }
        public override void OnInvoke(MethodInterceptionArgs args)
        {
            var methodName = string.Format("{0}.{1}.{2}",
                args.Method.ReflectedType.Namespace,
                args.Method.ReflectedType.Name,
                args.Method.Name);
            var arguments = args.Arguments.ToList();
            var key=string.Format("{0}({1})",methodName,string.Join(",",arguments.Select(x=>x!=null?x.ToString():"<Null>")));
            if (_cacheManager.isAdd(key))
            {
                args.ReturnValue = _cacheManager.Get<object>(key);
            }
            base.OnInvoke(args);
            _cacheManager.Add(key,args.ReturnValue,_cacheByMinute);
        }
    }
}
