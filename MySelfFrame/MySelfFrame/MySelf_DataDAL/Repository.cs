/********************************************************************************
** FileName   :Repository
** Description:无
** Author     :WK 
** Date       :2017/2/9 10:21:47
** Year       :2017
** Company    :成都新得利
** Version    :V1.0.0
*********************************************************************************/


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySelf_DataDAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private DbSet dbSet;
        public Repository(DbContext context)
        {
            this._dbContext = context;
            this.dbSet = _dbContext.Set<T>();
        }



        public bool AddEntity(T entity, out string info)
        {
            info = "正常";

            dbSet.Add(entity);
            return _dbContext.SaveChanges() > 0 ? true : false;
        }

        public bool DeleteEntity(T entity, out string info)
        {
            info = "正常";
            dbSet.Remove(entity);
            return _dbContext.SaveChanges() > 0 ? true : false;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool EditEntity(T entity, out string info)
        {
            info = "正常";
            
            //var obj1 = _dbContext.Entry(entity);
            //if (obj1.State == EntityState.Detached)
            //{
            //    dbSet.Attach(entity);
            //    //obj1.State = EntityState.Modified;
            //}

            //dbSet.Attach(entity);//附加到上下文
             _dbContext.Entry(entity).State = EntityState.Modified;
            //_dbContext.Entry(entity).CurrentValues.SetValues(entity); 
            return _dbContext.SaveChanges() > 0 ? true : false;
        }

        public IEnumerable<T> GetALlEntity()
        {

            List<T> list = _dbContext.Set<T>().ToList();
            return list;
        }

        public T GetEntityByWhere(object id, out string info)
        {
            info = "";
            T o = (T)dbSet.Find(Convert.ToInt32(id));

            return o;
        }

        public void Save()
        {
            this._dbContext.SaveChanges();
        }
    }
}
