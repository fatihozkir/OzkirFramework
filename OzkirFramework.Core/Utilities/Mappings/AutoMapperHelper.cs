using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace OzkirFramework.Core.Utilities.Mappings
{
    public class AutoMapperHelper
    {
        public static List<T> MapTo_T_TypeList<T>(List<T> list)
        {
            Mapper.Initialize(c => { c.CreateMap<T, T>(); });
            List<T> result = Mapper.Map<List<T>, List<T>>(list);
            return result;
        }
        public static T MapTo_T_Type<T>(T obj)
        {
            Mapper.Initialize(c => { c.CreateMap<T, T>(); });
            T result = Mapper.Map<T,T>(obj);
            return result;
        }
    }
}
