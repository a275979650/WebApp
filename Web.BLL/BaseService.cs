using System;
using System.Linq;
using System.Linq.Expressions;
using Web.DAL;
using Web.IDAL;
namespace Web.BLL
{
    public abstract class BaseService<T> where T : class, new()
    {
        public IDAL.IBaseRepository<T> CurrentRepository { get; set; }
        public DbSession _DbSession = new DbSession();
        public BaseService()
        {
            SetCurrentRepository();
        }

        public abstract void SetCurrentRepository(); //子类必须实现

        public T AddEntity(T entity)
        {
            //调用T对应的仓储来做添加工作
            var addEntity = CurrentRepository.AddEntity(entity);
            _DbSession.SaveChanges();
            return addEntity;
        }

        public bool UpdateEntity(T entity)
        {
            CurrentRepository.UpdateEntity(entity);
            return _DbSession.SaveChanges() > 0;
        }

        public bool DeleteEntity(T entity)
        {
            CurrentRepository.DeleteEntity(entity);
            return _DbSession.SaveChanges() > 0;
        }

        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            return CurrentRepository.LoadEntities(whereLambda);
        }

        public IQueryable<T> LoadPageEntities<S>(int pageIndex, int pageSize, out int total, Expression<Func<T, bool>> whereLambda,
            bool isAsc, Expression<Func<T, S>> orderByLambda)
        {
            return CurrentRepository
                .LoadPageEntities(pageIndex, pageSize, out total, whereLambda, isAsc, orderByLambda);
        }
    }
}
