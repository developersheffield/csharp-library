using RepositoryPattern.Model;
using RepositoryPattern.Repository;
using System;
using System.Data.Objects;

namespace RepositoryPattern
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();

        IObjectSet<TEntity> CreateObjectSet<TEntity>() where TEntity : class;

        bool EnableLazyLoading { get; set; }

        // TODO: Add property for each repository required
        IRepository<SampleClass> SampleClasses { get; }
    }
}
