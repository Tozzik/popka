using Microsoft.EntityFrameworkCore;
using popka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popka.Models
{
    public class Repos
    {
        private readonly OooPosudaContext _dbcontext = new OooPosudaContext();
        public List<T> readsql<T>(string sql) where T : class
        {
            _dbcontext.ChangeTracker.Clear();
            return _dbcontext.Set<T>().FromSqlRaw(sql).ToList();
        }
        public List<T> read<T>() where T : class
        {
            return _dbcontext.Set<T>().ToList();
        }

        public int ExecuteSql(string sql)
        {
            return _dbcontext.Database.ExecuteSqlRaw(sql);
        }


    }

}
