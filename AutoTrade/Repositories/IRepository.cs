using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTrade.Repositories
{
    public interface IRepository<T>
    {
        void Insert<T>(T t);
        void Delete<T>(T t);
        void Update<T>(T t);
    }
}