using RepositoryPattern.Model;
using RepositoryPattern.Repository;
using System.Configuration;
using System.Data.Objects;

namespace RepositoryPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ObjectContext context;

        public UnitOfWork()
        {
            // TODO: Set connection string name
            string connectionString = ConfigurationManager.ConnectionStrings["Connection string name"].ConnectionString;
            context = new ObjectContext(connectionString);
            context.ContextOptions.LazyLoadingEnabled = true;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public IObjectSet<TEntity> CreateObjectSet<TEntity>() where TEntity : class
        {
            return context.CreateObjectSet<TEntity>();
        }

        public bool EnableLazyLoading
        {
            get { return context.ContextOptions.LazyLoadingEnabled; }
            set { context.ContextOptions.LazyLoadingEnabled = value; }
        }

        // TODO: All repository properties
        public IRepository<SampleClass> SampleClasses => new SampleClassRepository(this);

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
