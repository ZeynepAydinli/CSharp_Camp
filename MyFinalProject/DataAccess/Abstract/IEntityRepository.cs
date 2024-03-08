using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract;

// generic constraint
public interface IEntityRepository<T> where T : class, IEntity, new()
{
    // GetAll metodunda filtre expression ile uygulanılır.
    // filter = null açıklaması Ef<T>Dal sınıfında vardır. 
    List<T> GetAll(Expression<Func<T, bool>> filter = null);
    T Get(Expression<Func<T, bool>> filter);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}
