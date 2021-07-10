using domain.Entities;
using System.Linq;

namespace repository
{
    public interface IChatterRepository
    {
        IQueryable<Chatter> SelectAll();
        Chatter InsertNew(Chatter chatter);
    }
}
