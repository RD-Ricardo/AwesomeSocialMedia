using ASM.Core.DomainObjects;

namespace ASM.Core.Data
{
    public interface IRepository<TEntity> where TEntity : AggregateRoot
    {
    }
}
