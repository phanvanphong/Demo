using Microsoft.EntityFrameworkCore;
using OA.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public interface IRepository<T> where T : BaseEnity
    {
        IQueryable<T> GetAll();
        Task<T> Get(long id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<int> Count();
        void Remove(T entity);
        Task SaveChanges();


        // Liên quan đến phân trang
        // Pager<T> Paging(Expression<Func<T, bool>> condition,  Expression<Func<T, dynamic>> include, int currentPage, int pageSize);
        // Pager<T> Paging(Expression<Func<T, bool>> condition, int currentPage, int pageSize,params Expression<Func<T, object>>[] includes);
        
        Task<Pager<T>> Paging(Expression<Func<T, bool>> condition, int currentPage, int pageSize, params Expression<Func<T, object>>[] includes);

        // Select dữ liệu
        Task<IEnumerable<T>> SelectData(Expression<Func<T, bool>> condition, Expression<Func<T, object>> orderby, params Expression<Func<T, object>>[] includes);

       
    }
}
