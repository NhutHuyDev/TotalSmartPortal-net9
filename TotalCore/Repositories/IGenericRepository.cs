using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Storage;
using TotalBase.Enums;

namespace TotalCore.Repositories
{
    public interface IGenericRepository<TEntity> : IBaseRepository
        where TEntity : class
    {
        IDbContextTransaction BeginTransaction();

        // For Loading (09/07/2015) - let review and optimize Loading laster
        IQueryable<TEntity> Loading(string aspUserID, GlobalEnums.NmvnTaskID nmvnTaskID);

        IQueryable<TEntity> GetAll();
        TEntity GetByID(int id);

        TEntity GetEntity(params Expression<Func<TEntity, object>>[] includes);
        TEntity GetEntity(bool proxyCreationEnabled, params Expression<Func<TEntity, object>>[] includes);
        TEntity GetEntity(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        TEntity GetEntity(bool proxyCreationEnabled, Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);

        ICollection<TEntity> GetEntities(params Expression<Func<TEntity, object>>[] includes);
        ICollection<TEntity> GetEntities(bool proxyCreationEnabled, params Expression<Func<TEntity, object>>[] includes);
        ICollection<TEntity> GetEntities(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        ICollection<TEntity> GetEntities(bool proxyCreationEnabled, Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);

        bool GetApproved(int id);
        bool GetEditable(int id);
        bool GetDeletable(int id);
        bool GetVoidable(int id);

        bool CheckExisting(int id, string functionName);
        string GetExisting(int id, string functionName);

        TEntity Add(TEntity entity);
        TEntity Remove(TEntity entity);

        int SaveChanges();
    }
}
