namespace App.Domain.Interfaces;

public interface IRepositoryBase<TEntity>
{
    IEnumerable<TEntity> GetAll();
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Remove(TEntity entity);
    TEntity FindById(int id);
}