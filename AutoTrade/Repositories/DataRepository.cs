using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTrade.Repositories
{
    public abstract class DataRepository<T> : IRepository<T> where T : class
    {
        public void Insert<T>(T t) {
        }
        public void Update<T>(T t)
        {
        }
        public void Delete<T>(T t)
        { 
        }
    }
}