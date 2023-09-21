using DesingPattern.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DesignPatternsContext _context;
        private DbSet<TEntity> _dbSet;   

        public Repository(DesignPatternsContext context)
        {
            _context = context;
            _dbSet=context.Set<TEntity>();  
        }

        public void Add(TEntity data)
        {
            _dbSet.Add(data);   
        }

        public void Delete(int id)
        {
            var data = _dbSet.Find(id);
            _dbSet.Remove(data);    
        }

        public IEnumerable<TEntity> Get()
        {
            return _dbSet.ToList();
        }

        public TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(TEntity data)
        {
            _dbSet.Attach(data);
            _context.Entry(data).State=EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
