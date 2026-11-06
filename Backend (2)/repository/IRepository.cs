using System;

namespace Backend.Reposity;

public interface IRepository<TEntity>
{
     Task<IEnumerable<TEntity>>Get();

     Task<TEntity>GEtById(int id);

     Task Add(TEntity entity);

     void Update(TEntity entity);

     void Delete(TEntity entity);

     Task save();
}