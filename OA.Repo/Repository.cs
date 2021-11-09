using DemoDotNet5.Data;
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

    // Khai báo class Repository kiểu Generic kế thừa interface Irepository và kế thừa class BaseEntity
    public class Repository<T> : IRepository<T> where T : BaseEnity
    {
        private readonly EShopDbContext context;
        // Khai báo thuộc tính entities có kiểu DBSet generic (chính là table ở CSDL)
        public DbSet<T> entities;
        // string errorMessage = string.Empty;
        public Repository(EShopDbContext context)
        { 
            this.context = context;
            entities = context.Set<T>();
        }
        public async Task Delete(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<T> Get(long id)
        {
            // SingleOrDefault trả về phần tử duy nhất thõa mãn điều kiện
            return await entities.SingleOrDefaultAsync(s => s.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }

        public async Task Insert(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            await context.SaveChangesAsync();
        }

        public void Remove(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public async Task SaveChanges()
        {
           await context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            await context.SaveChangesAsync();
        }

        public async Task<Pager<T>> Paging(Expression<Func<T, bool>> condition, int currentPage, int pageSize, params Expression<Func<T, object>>[] includes)
        {
            // Kiểu params có thể nhận giá trị null , 1 or nhiều (danh sách)
            // Example: var query = context.Set<T>.AsQueryable
            // Phương thức AsQueryable() nhằm tạo câu truy vấn chứ chưa thực hiện truy vấn
            var query = entities.AsQueryable();
            // Duyệt từng phần tử của mảng includes
            foreach(Expression<Func<T, object>> include in includes)
            {
                query = query.Include(include);
            }
            // Thêm điều kiện
            var data = query.Where(condition);
            if (currentPage == 0) currentPage = 1;
            if (pageSize == 0) pageSize = 4;
            var totalItems = await data.CountAsync();
            var items = await data.Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
            return new Pager<T>(items, totalItems, currentPage, pageSize);
        }

        public async Task<IEnumerable<T>> SelectData(Expression<Func<T, bool>> condition, Expression<Func<T, object>> orderby , params Expression<Func<T, object>>[] includes)
        {
            // Kiểu params có thể nhận giá trị null , 1 or nhiều (danh sách)
            // Example: var query = context.Set<T>.AsQueryable
            // Phương thức AsQueryable() nhằm tạo câu truy vấn chứ chưa thực hiện truy vấn
            var query = entities.AsQueryable();
            // Duyệt từng phần tử của mảng includes
            foreach (Expression<Func<T, object>> include in includes)
            {
                query = query.Include(include);
            }
            // Thêm điều kiện
            var data = query.Where(condition).OrderByDescending(orderby);
            var items = await data.ToListAsync();
            return items;
        }

        public async Task<int> Count()
        {
            return await entities.CountAsync();
        }
    }
}
