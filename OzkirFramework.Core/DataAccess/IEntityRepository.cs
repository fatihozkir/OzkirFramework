using OzkirFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OzkirFramework.Core.DataAccess
{
    //Alttaki ifade ile Generic tipli interface'imizin bir Class olması gerektiğini ve bu class'ın abstract vs olmasını engellemek için gelen class'ın new ile bir instance üretilmiş nesne olmasını açıkladık.
    public interface IEntityRepository<T> where T:class,IEntity,new ()
    {
        List<T> GetList(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T,bool>> filter=null);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
