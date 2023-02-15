using ITBlog.DataAccess.ContextFolder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.DataAccess.RepositoryFolder
{
    public partial class EfRepository<T> : IRepository<T> where T : class, new()
    {
        #region Fields
        private readonly ITBlogContext _iTBlogContext;
        private DbSet<T> _dbSet;
        #endregion

        #region Ctor
        public EfRepository(ITBlogContext iTBlogContext)
        {
            this._iTBlogContext = iTBlogContext;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Get Entity with Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(Guid id)
        {
            return this.Entities.Find(id);
        }

        /// <summary>
        /// Get All Entities
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return this.Entities.ToList();
        }
        /// <summary>
        /// Insert Entity
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Entity is null!");
            this.Entities.Add(entity);
            this._iTBlogContext.SaveChanges();
        }

        /// <summary>
        /// Insert Entities
        /// </summary>
        /// <param name="entities"></param>
        public void Insert(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("Entities are null!");
                foreach (var item in entities)
                    this.Entities.Add(item);
                this._iTBlogContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Update Entity
        /// </summary>
        /// <param name="entity"></param>
        public int Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    return 0;
                }
                this._iTBlogContext.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// Update Entities
        /// </summary>
        /// <param name="entities"></param>
        public void Update(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("Entities are null!");
                this._iTBlogContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Delete Entity
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("Entity is null!");
                this.Entities.Remove(entity);
                this._iTBlogContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Delete Entities
        /// </summary>
        /// <param name="entities"></param>
        public void Delete(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("Entities are null!");
                foreach (var item in entities)
                    this.Entities.Remove(item);
                this._iTBlogContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Properties
        /// <summary>
        /// Set Entities
        /// </summary>
        protected virtual Microsoft.EntityFrameworkCore.DbSet<T> Entities
        {
            get
            {
                if (_dbSet == null)
                {
                    _dbSet = _iTBlogContext.Set<T>();
                }
                return _dbSet;
            }
        }

        /// <summary>
        /// Gets a Table
        /// </summary>
        public IQueryable<T> Table { get { return this.Entities; } }

        public virtual List<T> Query(Expression<Func<T, bool>> predicate, string includedProperties)
        {
            if (predicate == null && !string.IsNullOrEmpty(includedProperties))
            {
                if (includedProperties.Contains('|'))
                {
                    var splittedInclude = includedProperties.Split('|');
                    foreach (var item in splittedInclude)
                    {
                        this.Entities.Include(item).ToList();
                    }

                    return this.Entities.ToList();
                }

                if (this.Entities.Any())
                {
                    return this.Entities.Include(includedProperties).ToList();
                }
                else
                {
                    return this.Entities.ToList();
                }
            }
            else if (predicate != null && !string.IsNullOrEmpty(includedProperties) && includedProperties.Contains('|'))
            {
                var resultEntities = this.Entities;
                var splittedInclude = includedProperties.Split('|');
                foreach (var item in splittedInclude)
                {
                    try
                    {
                        resultEntities.Include(item).ToList().AsQueryable();
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }

                return resultEntities.Where(predicate).ToList();
            }
            else if (!string.IsNullOrEmpty(includedProperties))
            {
                return this.Entities.Where(predicate).Include(includedProperties).ToList();
            }
            else
            {
                return this.Entities.Where(predicate).ToList();
            }
        }

        #endregion

    }
}
