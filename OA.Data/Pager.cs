using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data
{
    public class Pager<T> : List<T>
    {
        public Pager(List<T> items, int totalItems, int currentPage, int pageSize)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
            Items = items;
        }

        
        //public Pager(List<T> items, int totalItems, int currentPage, int pageSize)
        //{
        //    CurrentPage = currentPage;
        //    PageSize = pageSize;
        //    // Tính tổng số Page
        //    TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
        //    Items = items;
        //    TotalItems = totalItems;
        //}
        

        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public List<T> Items { get; set; }
    }
}
