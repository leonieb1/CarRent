namespace CarRent.Common.Domain
{
    public interface IRepository<Taggregate>
        where Taggregate : Entity, new()
    {
        Taggregate GetByID(Guid id);
        void Add(Taggregate car);
        void Update(Taggregate car);
        void Remove(Taggregate car);
    }
}
