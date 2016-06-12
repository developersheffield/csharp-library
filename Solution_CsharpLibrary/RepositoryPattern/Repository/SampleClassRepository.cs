using RepositoryPattern.Model;

namespace RepositoryPattern.Repository
{
    public sealed class SampleClassRepository : BaseRepository<SampleClass>
    {
        public SampleClassRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
